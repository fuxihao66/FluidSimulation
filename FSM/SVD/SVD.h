#pragma once


#ifdef SVDEIGEN_EXPORTS
#define SVD_API __declspec(dllexport)
#else
#define SVD_API __declspec(dllimport)
#endif

extern "C" {

	/*BCCREAD_API int ReadBCCFile(const char* bccFilePath, unsigned char* vertexBuffer, unsigned int* indicesBuffer, unsigned int& vertexNum, unsigned int& indexNum);*/
	SVD_API int SVD_Eigen(float* Matrix_A, float* Vector_B, int rowNum, int colNum, float* ReturnedValue);

}
