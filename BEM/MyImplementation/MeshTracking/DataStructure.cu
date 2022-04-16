
struct TriangleMesh{
    
    #ifdef WRITE
    RWBuffer<float3> Vertices;
    #else
    Buffer<float3>   Vertices;
    #endif

    #ifdef WRITE
    RWBuffer<uint>   Indices;
    #else
    Buffer<uint>     Indices;
    #endif
    
    uint TriangleNums;
    uint VertexNums;

    #ifdef WRITE
    void AppendVertexAtomic(){
        Vertices[];
    }
    void AppendTriangleAtomic(){
        
    }
    #endif
};

struct HashTable{
    
};

struct KeyValueMap{

};