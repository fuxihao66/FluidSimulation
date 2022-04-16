#----------------------------------------------------------------
# Generated CMake target import file for configuration "MinSizeRel".
#----------------------------------------------------------------

# Commands may need to know the format version.
set(CMAKE_IMPORT_FILE_VERSION 1)

# Import target "blas" for configuration "MinSizeRel"
set_property(TARGET blas APPEND PROPERTY IMPORTED_CONFIGURATIONS MINSIZEREL)
set_target_properties(blas PROPERTIES
  IMPORTED_LINK_INTERFACE_LANGUAGES_MINSIZEREL "Fortran"
  IMPORTED_LOCATION_MINSIZEREL "${_IMPORT_PREFIX}/lib/blas.lib"
  )

list(APPEND _IMPORT_CHECK_TARGETS blas )
list(APPEND _IMPORT_CHECK_FILES_FOR_blas "${_IMPORT_PREFIX}/lib/blas.lib" )

# Import target "lapack" for configuration "MinSizeRel"
set_property(TARGET lapack APPEND PROPERTY IMPORTED_CONFIGURATIONS MINSIZEREL)
set_target_properties(lapack PROPERTIES
  IMPORTED_LINK_INTERFACE_LANGUAGES_MINSIZEREL "Fortran"
  IMPORTED_LOCATION_MINSIZEREL "${_IMPORT_PREFIX}/lib/lapack.lib"
  )

list(APPEND _IMPORT_CHECK_TARGETS lapack )
list(APPEND _IMPORT_CHECK_FILES_FOR_lapack "${_IMPORT_PREFIX}/lib/lapack.lib" )

# Commands beyond this point should not need to know the version.
set(CMAKE_IMPORT_FILE_VERSION)
