# Load lapack targets from the build tree if necessary.
set(_LAPACK_TARGET "blas")
if(_LAPACK_TARGET AND NOT TARGET "${_LAPACK_TARGET}")
  include("D:/FluidSimulation/BEM/source/lapack-3.10.0/built/lapack-targets.cmake")
endif()
unset(_LAPACK_TARGET)

# Hint for project building against lapack
set(LAPACK_Fortran_COMPILER_ID "Intel")

# Report the blas and lapack raw or imported libraries.
set(LAPACK_blas_LIBRARIES "blas")
set(LAPACK_lapack_LIBRARIES "lapack")
set(LAPACK_LIBRARIES ${LAPACK_blas_LIBRARIES} ${LAPACK_lapack_LIBRARIES})
