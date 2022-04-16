
1. 确定所有不合法的三角形集合D
2. relax iteration
    while()
        * topological noise
    重建D
3. 删除mesh中出现在D中的三角形
4. 删除mesh中在volume里面或velocity不合法的三角形，并加入D中
5. while
    * 保证mesh是manifold
    * pair and fill
    * 不能填补的区域删除临近的三角形，更新D
6. 质量更新
