#include "pch.h"
#include "framework.h"
#include "SVD.h"

#include "Eigen/Dense"

#include <cstdio>
#include <vector>

using namespace Eigen;

//typedef unsigned long long uint64_t;
//struct FVector3 {
//    float x;
//    float y;
//    float z;
//};
extern "C" {
    
    SVD_API int SVD_Eigen(float* Matrix_A, float* Vector_B, int rowNum, int colNum, float* ReturnedValue, int offset)
    {
        MatrixXf A = MatrixXf::Random(rowNum, colNum);
        
        VectorXf b = VectorXf::Random(rowNum);


        memcpy(A.data(), Matrix_A, rowNum * colNum * sizeof(float));
        memcpy(b.data(), Vector_B, rowNum * sizeof(float));

        VectorXf result = A.bdcSvd(ComputeThinU | ComputeThinV).solve(b);
        memcpy(ReturnedValue + offset, result.data(), colNum * sizeof(float));

        return 0;
    }

    /*SVD_API int SVD_Cuda() {

    }*/
}