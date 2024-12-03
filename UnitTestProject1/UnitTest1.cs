using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniTest;

namespace UniTest.Tests
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void TestAllPermutations_SmallArray()
        {
           
            int[] nums = { 1, 2, 3 };
            var expected = new List<List<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 1, 3, 2 },
                new List<int> { 2, 1, 3 },
                new List<int> { 2, 3, 1 },
                new List<int> { 3, 1, 2 },
                new List<int> { 3, 2, 1 }
            };

          
            var result = new List<List<int>>();
            Solution.GeneratePermutations(nums, 0, result);

           
            Assert.AreEqual(expected.Count, result.Count, "Количество перестановок не совпадает.");
            foreach (var perm in expected)
            {
                Assert.IsTrue(result.Exists(r => AreEqual(r, perm)), $"Перестановка {string.Join(", ", perm)} не найдена.");
            }
        }

        [TestMethod]
        public void TestAllPermutations_SingleElement()
        {
           
            int[] nums = { 1 };
            var expected = new List<List<int>>
            {
                new List<int> { 1 }
            };

          
            var result = new List<List<int>>();
            Solution.GeneratePermutations(nums, 0, result);

          
            Assert.AreEqual(expected.Count, result.Count, "Количество перестановок не совпадает.");
            Assert.IsTrue(AreEqual(result[0], expected[0]), "Перестановка для одного элемента не совпадает.");
        }

        [TestMethod]
        public void TestAllPermutations_EmptyArray()
        {
          
            int[] nums = { };
            var expected = new List<List<int>>
            {
                new List<int> { }
            };

            
            var result = new List<List<int>>();
            Solution.GeneratePermutations(nums, 0, result);

           
            Assert.AreEqual(expected.Count, result.Count, "Количество перестановок не совпадает.");
            Assert.IsTrue(AreEqual(result[0], expected[0]), "Перестановка для пустого массива не совпадает.");
        }

        private bool AreEqual(List<int> a, List<int> b)
        {
            if (a.Count != b.Count) return false;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true;
        }
    }
}
