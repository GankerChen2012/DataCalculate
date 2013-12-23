using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataCalculate
{
    internal class Tree
    {
        public Tree()
        {

        }


        private void ParentTrees()
        {
            var list = new List<ParentTree>
                {
                    new ParentTree() {Id = 1, Data = "A", Parent = -1},
                    new ParentTree() {Id = 2, Data = "B", Parent = 1},
                    new ParentTree() {Id = 3, Data = "C", Parent = 1},
                    new ParentTree() {Id = 4, Data = "D", Parent = 2},
                    new ParentTree() {Id = 5, Data = "E", Parent = 3},
                    new ParentTree() {Id = 6, Data = "F", Parent = 3},
                    new ParentTree() {Id = 7, Data = "G", Parent = 3},
                    new ParentTree() {Id = 8, Data = "H", Parent = 6},
                    new ParentTree() {Id = 9, Data = "I", Parent = 6},
                    new ParentTree() {Id = 10, Data = "J", Parent = 6},
                    new ParentTree() {Id = 11, Data = "K", Parent = 8}
                };
        }

        private void TreeRank()
        {
            var list = new[] {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};






        }

        private void Lchild()
        {

        }


    }

    internal class ParentTree
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public int Parent { get; set; }
    }

}
