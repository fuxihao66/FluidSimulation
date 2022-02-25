using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System;
using UnityEngine.Rendering;

public class waveAnim : MonoBehaviour {
    public ComputeShader computeShader;
    public int gridX = 101;
    public int gridY = 101;
    public Vector2 sampleCenter = new Vector2(0.0f, 0.0f);
    public float radius = 1.0f;

    public int maxK = 10;

    public Vector3 InFlow = new Vector3();




    private int kernelIndex;
    private ComputeBuffer buffer;
    private int[] InFlow_FT;
    // Use this for initialization
    // 把预计算直接放在这里面

    private void GenerateSourceSamples(Vector2[] sampleVec, uint sampleCount)
    {

    }
    private void GenerateBoundarySamples(Vector2[] sampleVec, uint sampleCount)
    {

    }

    [DllImport("SVD_Eigen", EntryPoint = "SVD_Eigen")]
    public static unsafe extern int SVD_Eigen(float* Matrix_A, float* Vector_B, int rowNum, int colNum, float* ReturnedValue, int offset);
    void Start () {
        Vector2[] samplesBoundary;
        Vector2[] samplesSource;
        uint boundarySampleCount = ;
        uint sourceSampleCount = ;
        GenerateSourceSamples(samplesSource, sourceSampleCount);
        GenerateBoundarySamples(samplesBoundary, boundarySampleCount);

        Mesh mesh = new Mesh();
        Vector3[] vertices = new Vector3[10000000];
        int[] indices = new int[10000000];




        float[] precomputedBuffer = new float[];

        for (int i = 0; i < maxK; i++)
        {
            unsafe
            {
                float[] Matrix = new float[];
                float[] b = new float[];
                int rowNum = ;
                int colNum = ;
                int resultOffset = ;


                for (int rIndex = 0; rIndex < rowNum; rIndex++)
                {
                    for (int cIndex = 0; cIndex < colNum; cIndex++)
                    {
                        Matrix[] = ;
                    }
                    b[] = ;
                }


                //Pin array then send to C++
                fixed (float* matPtr = Matrix)
                {
                    fixed (float* vecPtr = b)
                    {
                        fixed (float* resultPtr = precomputedBuffer)
                        {
                            SVD_Eigen(matPtr, vecPtr, rowNum, colNum, resultPtr, resultOffset);
                        }
                    }
                }
            }
        }

        // upload data to a buffer for compute shader



        kernelIndex = computeShader.FindKernel("CSMain");
    }
	
	// Update is called once per frame
    // 只需要用compute shader来eval新位置就可以
	void Update () {
        //computeShader.SetTexture(kernelIndex, "Result", mRenderTexture);
        computeShader.SetBuffer(kernelIndex, "CoeffBuffer", buffer);
        computeShader.SetBuffer(kernelIndex, "Result", meshVertex);
        computeShader.SetInt("maxK", maxK);
        computeShader.SetInt("maxSourceSamplesCount", );
        computeShader.SetInt("Width", );
        computeShader.SetInt("Height", );
        computeShader.SetFloat("time", );


        computeShader.Dispatch(kernelIndex, gridX, gridY, 1);
    }
}
