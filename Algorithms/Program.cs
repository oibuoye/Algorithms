using Algorithms.BinarySearchTree;
using Algorithms.BinarySearchTree.Solutions;
using Algorithms.DynamicProgramming;
using Algorithms.Leetcodechallenge.Day01;
using Algorithms.Leetcodechallenge.Day02;
using Algorithms.Leetcodechallenge.Day03;
using Algorithms.Leetcodechallenge.Day04;
using Algorithms.Leetcodechallenge.Day05;
using Algorithms.Leetcodechallenge.Day06;
using Algorithms.Leetcodechallenge.Day07;
using Algorithms.Solutions;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//using static Algorithms.LinkedList.LinkedList;
using Algorithms.Leetcodechallenge.Day08;
using Algorithms.Leetcodechallenge.Day09;
using Algorithms.Leetcodechallenge.Day10;
using Algorithms.Leetcodechallenge.Day11;
using Algorithms.Leetcodechallenge.Day12;
using Algorithms.Leetcodechallenge.Day13;
using Algorithms.Leetcodechallenge.Day14;
using Algorithms.Leetcodechallenge.Day19;
using Algorithms.Leetcodechallenge.Day15;
using Algorithms.Leetcodechallenge.Day20;
using Algorithms.Leetcodechallenge.Day22;
using Algorithms.Leetcodechallenge.Day25;
using Algorithms.Leetcodeweeklycontest;
using Algorithms.Leetcodechallenge.Day27;
using Algorithms.Leetcodechallenge.May.Day02;
using Algorithms.Leetcodechallenge.May.Day01;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            #endregion

            #region SA

            #region ProductofArrayExceptSelf Solution
            //int[] arr = { 1, 2, 3, 4 };
            //int[] arr = { 0, 0 };
            //var result = ProductofArrayExceptSelf.ProductExceptSelf(arr);
            #endregion


            #endregion

            #region Abbreviation: You can perform the following operations on the string, :
            ////Capitalize zero or more of 's lowercase letters.
            ////Delete all of the remaining lowercase letters in .
            ////Given two strings,  and , determine if it's possible to make  equal to  as described. If so, print YES on a new line. Otherwise, print NO.

            //string astring = "AbBcDE";
            //string bstring = "ABDE";
            //string abbResult = Abbreviation.GetAbbreviation(astring, bstring);
            #endregion

            #region MaxArraySum: Find the subset of non-adjacent elements with the maximum sum
            //int[] dif = { -2, 1, 3, -4, 5, 8, 9 };
            //int[] dif = { -2, 1, 1, 4, -1, 5 };
            //int maxResult = MaxArraySum.maxSubsetSum(dif);
            #endregion

            #region Binary Search Tree:: Right skewed tree, Left skewed tree, CheckIsSameTree

            //////Right skewed tree
            ////var rightNode = new RightSkewedTree().GetRightSkewedTree();

            //////Left skewed tree
            ////var leftNode = new LeftSkewedTree().GetLeftSkewedTree();

            ////Node root = null;
            ////TreeOperations bst = new TreeOperations();
            ////int SIZE = 200000;
            ////int[] a = new int[SIZE];

            ////Console.WriteLine("Generating random array with {0} values...", SIZE);

            ////Random random = new Random();

            ////Stopwatch watch = Stopwatch.StartNew();

            ////for (int i = 0; i < SIZE; i++)
            ////{
            ////    a[i] = random.Next(1000);
            ////}

            ////watch.Stop();

            ////Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 100.0);
            ////Console.WriteLine();
            ////Console.WriteLine("Filling the tree with {0} nodes...", SIZE);

            ////watch = Stopwatch.StartNew();

            ////for (int i = 0; i < SIZE; i++)
            ////{
            ////    //Insert value into the nodes
            ////    root = bst.Insert(root, a[i]);
            ////}

            ////watch.Stop();

            ////Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 100.0);
            ////Console.WriteLine();
            ////Console.WriteLine("Traversing all {0} nodes in tree...", SIZE);

            ////watch = Stopwatch.StartNew();

            //////Move through the nodes
            ////bst.Tranverse(root);

            ////watch.Stop();

            ////Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 100.0);
            ////Console.WriteLine();


            ////Node tree = BinarySearchTree.BinarySearchTree.CreateNewNode(1);
            ////tree.left = BinarySearchTree.BinarySearchTree.CreateNewNode(2);
            ////tree.right = BinarySearchTree.BinarySearchTree.CreateNewNode(2);
            ////tree.left.left = BinarySearchTree.BinarySearchTree.CreateNewNode(3);
            ////tree.left.right = BinarySearchTree.BinarySearchTree.CreateNewNode(4);
            ////tree.right.left = BinarySearchTree.BinarySearchTree.CreateNewNode(5);
            ////tree.right.right = BinarySearchTree.BinarySearchTree.CreateNewNode(3);
            ////Boolean output = CheckIsTreeSymmetric.IsTreeSymmetric(tree);

            //Node tree1 = BinarySearchTree.BinarySearchTree.CreateNewNode(1);
            //tree1.left = BinarySearchTree.BinarySearchTree.CreateNewNode(2);
            //tree1.right = BinarySearchTree.BinarySearchTree.CreateNewNode(1);
            ////tree1.left.left = BinarySearchTree.BinarySearchTree.CreateNewNode(3);
            ////tree1.left.right = BinarySearchTree.BinarySearchTree.CreateNewNode(4);
            ////tree1.right.left = BinarySearchTree.BinarySearchTree.CreateNewNode(5);
            ////tree1.right.right = BinarySearchTree.BinarySearchTree.CreateNewNode(3);

            //Node tree2 = BinarySearchTree.BinarySearchTree.CreateNewNode(1);
            //tree2.left = BinarySearchTree.BinarySearchTree.CreateNewNode(null);
            //tree2.right = BinarySearchTree.BinarySearchTree.CreateNewNode(2);
            ////tree2.left.left = BinarySearchTree.BinarySearchTree.CreateNewNode(3);
            ////tree2.left.right = BinarySearchTree.BinarySearchTree.CreateNewNode(4);
            ////tree2.right.left = BinarySearchTree.BinarySearchTree.CreateNewNode(5);
            ////tree2.right.right = BinarySearchTree.BinarySearchTree.CreateNewNode(3);
            //Boolean output1 = CheckIsSameTree.IsSameTree(tree1, tree2);

            #endregion

            #region Subsequences
            //string word = "abcabc";
            //int subResult = CountSubsequencesofType.GetSubsequentType(word);
            #endregion

            #region Biological Poisonous gas

            //var affected = new List<int>() { 1, 2 };
            //var poisonous = new List<int>() { 3, 5 };
            //int n = 5;
            //long result = BiologicalHazards.BioHazardSol2(n, affected, poisonous);

            #endregion

            #region GetTransactions

            //int locationId = 1;
            //string txnType = "debit";
            //var result = TransactionStatement.getTxnAmountByLocation(locationId, txnType);

            #endregion

            #region Count Meeting
            //99627
            ////var arrival = new List<int>() { 1, 2, 2, 1 };
            ////var departure = new List<int>() { 1, 2, 2, 3 };
            //var arrival = new List<int>() { 1, 1, 2 };
            //var departure = new List<int>() { 1, 2, 2 };
            ////var arrival = new List<int>() { 1, 2, 1, 2, 2 };
            ////var departure = new List<int>() { 3, 2, 1, 3, 3 };
            //var arrival = new List<int>() { 7, 7, 7 };
            //var departure = new List<int>() { 8, 11, 8 };
            //var arrival = new List<int>() { 1, 1, 1, 2 };
            //var departure = new List<int>() { 2, 2, 3, 3 };
            //var arrival = new List<int>() { 10, 11, 12, 14,13, 10, 11, 15 , 15};
            //var departure = new List<int>() { 13, 14, 15, 14, 15, 10, 11, 15 , 15};
            //var arrival = new List<int>() { 1 };
            //var departure = new List<int>() { 1000 };

            //var resul2 = countMeetingSolution.countMeetings(arrival, departure);

            #endregion

            #region chooseFlask : Different measurement for different requirement, pick flask with lowest cost loss

            #region Should return 0
            //var req = new List<int>() { 4, 6 };
            //int flaskType = 2;
            //var f1 = new List<int>() { 0, 5 };
            //var f2 = new List<int>() { 0, 7 };
            //var f3 = new List<int>() { 0, 10 };
            //var f4 = new List<int>() { 1, 4 };
            //var f5 = new List<int>() { 1, 10 };
            //var marking = new List<List<int>>();
            //marking.Add(f1);
            //marking.Add(f2);
            //marking.Add(f3);
            //marking.Add(f4);
            //marking.Add(f5);
            #endregion

            #region Should return 0
            //var req = new List<int>() { 4, 6 };
            //int flaskType = 2;
            //var f1 = new List<int>() { 0, 6 };
            //var f2 = new List<int>() { 0, 7 };
            //var f3 = new List<int>() { 0, 10 };
            //var f4 = new List<int>() { 1, 4 };
            //var f5 = new List<int>() { 1, 10 };
            //var f6 = new List<int>() { 1, 11 };
            //var marking = new List<List<int>>();
            //marking.Add(f1);
            //marking.Add(f2);
            //marking.Add(f3);
            //marking.Add(f4);
            //marking.Add(f5);
            //marking.Add(f6);
            #endregion


            #region Should return 1
            //var req = new List<int>() { 10, 15 };
            //int flaskType = 3;
            //var f1 = new List<int>() { 0, 11 };
            //var f2 = new List<int>() { 0, 20 };
            //var f3 = new List<int>() { 1, 11 };
            //var f4 = new List<int>() { 1, 17 };
            //var f5 = new List<int>() { 2, 12 };
            //var f6 = new List<int>() { 2, 16 };
            //var marking = new List<List<int>>();
            //marking.Add(f1);
            //marking.Add(f2);
            //marking.Add(f3);
            //marking.Add(f4);
            //marking.Add(f5);
            //marking.Add(f6);
            #endregion

            #region Should return 0
            //var req = new List<int>() { 4, 6, 6, 7 };
            //int flaskType = 3;
            //var f1 = new List<int>() { 0, 3 };
            //var f2 = new List<int>() { 0, 5 };
            //var f3 = new List<int>() { 0, 7 };
            //var f4 = new List<int>() { 1, 6 };
            //var f5 = new List<int>() { 1, 8 };
            //var f6 = new List<int>() { 1, 9 };
            //var f7 = new List<int>() { 2, 3 };
            //var f8 = new List<int>() { 2, 5 };
            //var f9 = new List<int>() { 2, 6 };
            //var marking = new List<List<int>>();
            //marking.Add(f1);
            //marking.Add(f2);
            //marking.Add(f3);
            //marking.Add(f4);
            //marking.Add(f5);
            //marking.Add(f6);
            //marking.Add(f7);
            //marking.Add(f8);
            //marking.Add(f9);
            #endregion

            #region Should return 4
            //var req = new List<int>() { 673, 1257, 958, 973, 669, 454, 1420, 853, 1118, 1005 };
            //int flaskType = 15;
            //var f0 = new List<int>() { 0, 1 };
            //var f1 = new List<int>() { 0, 2 };
            //var f2 = new List<int>() { 0, 32 };
            //var f3 = new List<int>() { 0, 86 };
            //var f4 = new List<int>() { 0, 87 };
            //var f5 = new List<int>() { 0, 89 };
            //var f6 = new List<int>() { 0, 99 };
            //var f7 = new List<int>() { 0, 139 };
            //var f8 = new List<int>() { 0, 154 };
            //var f9 = new List<int>() { 0, 247 };

            //var f10 = new List<int>() { 0, 353 };
            //var f11 = new List<int>() { 0, 533 };
            //var f12 = new List<int>() { 0, 729 };
            //var f13 = new List<int>() { 0, 2683 };
            //var f14 = new List<int>() { 0, 5715 };
            //var f15 = new List<int>() { 0, 8187 };
            //var f16 = new List<int>() { 0, 10724 };
            //var f17 = new List<int>() { 0, 25119 };
            //var f18 = new List<int>() { 0, 130561 };
            //var f19 = new List<int>() { 0, 193836 };

            //var f20 = new List<int>() { 0, 296340 };
            //var f21 = new List<int>() { 0, 299561 };
            //var f22 = new List<int>() { 0, 1450991 };
            //var f23 = new List<int>() { 1, 1 };
            //var f24 = new List<int>() { 1, 7 };
            //var f25 = new List<int>() { 1, 30 };
            //var f26 = new List<int>() { 1, 186 };
            //var f27 = new List<int>() { 1, 965 };
            //var f28 = new List<int>() { 1, 13857 };
            //var f29 = new List<int>() { 1, 556519 };

            //var f30 = new List<int>() { 2, 1 };
            //var f31 = new List<int>() { 2, 4 };
            //var f32 = new List<int>() { 2, 21 };
            //var f33 = new List<int>() { 2, 1008 };
            //var f34 = new List<int>() { 2, 14488 };
            //var f35 = new List<int>() { 3, 2 };
            //var f36 = new List<int>() { 3, 7 };
            //var f37 = new List<int>() { 3, 9 };
            //var f38 = new List<int>() { 3, 18 };
            //var f39 = new List<int>() { 3, 20 };

            //var f40 = new List<int>() { 3, 47 };
            //var f41 = new List<int>() { 3, 48 };
            //var f42 = new List<int>() { 3, 105 };
            //var f43 = new List<int>() { 3, 203 };
            //var f44 = new List<int>() { 3, 469 };
            //var f45 = new List<int>() { 3, 962 };
            //var f46 = new List<int>() { 3, 4145 };
            //var f47 = new List<int>() { 3, 53019 };
            //var f48 = new List<int>() { 3, 115406 };
            //var f49 = new List<int>() { 3, 874965 };

            //var f50 = new List<int>() { 3, 1059655 };
            //var f51 = new List<int>() { 3, 1131207 };
            //var f52 = new List<int>() { 4, 1 };
            //var f53 = new List<int>() { 4, 1 };
            //var f54 = new List<int>() { 4, 1 };
            //var f55 = new List<int>() { 4, 2 };
            //var f56 = new List<int>() { 4, 6 };
            //var f57 = new List<int>() { 4, 7 };
            //var f58 = new List<int>() { 4, 9 };
            //var f59 = new List<int>() { 4, 16 };

            //var f60 = new List<int>() { 4, 48 };
            //var f61 = new List<int>() { 4, 100 };
            //var f62 = new List<int>() { 4, 674 };
            //var f63 = new List<int>() { 4, 1073 };
            //var f64 = new List<int>() { 4, 2087 };
            //var f65 = new List<int>() { 4, 4411 };
            //var f66 = new List<int>() { 4, 6540 };
            //var f67 = new List<int>() { 4, 9498 };
            //var f68 = new List<int>() { 4, 11177 };
            //var f69 = new List<int>() { 4, 105185 };

            //var f70 = new List<int>() { 4, 258420 };
            //var f71 = new List<int>() { 4, 602779 };
            //var f72 = new List<int>() { 5, 1 };
            //var f73 = new List<int>() { 5, 7 };
            //var f74 = new List<int>() { 5, 44 };
            //var f75 = new List<int>() { 5, 155 };
            //var f76 = new List<int>() { 5, 293 };
            //var f77 = new List<int>() { 5, 428 };
            //var f78 = new List<int>() { 5, 3661 };
            //var f79 = new List<int>() { 5, 54584 };

            //var f80 = new List<int>() { 5, 130213 };
            //var f81 = new List<int>() { 5, 1223172 };
            //var f82 = new List<int>() { 6, 25 };
            //var f83 = new List<int>() { 6, 47 };
            //var f84 = new List<int>() { 6, 1127 };
            //var f85 = new List<int>() { 6, 26574 };
            //var f86 = new List<int>() { 6, 76873 };
            //var f87 = new List<int>() { 6, 79755 };
            //var f88 = new List<int>() { 7, 3 };
            //var f89 = new List<int>() { 7, 4 };

            //var f90 = new List<int>() { 7, 14 };
            //var f91 = new List<int>() { 7, 1784 };
            //var f92 = new List<int>() { 7, 1989 };
            //var f93 = new List<int>() { 7, 2176 };
            //var f94 = new List<int>() { 7, 6973 };
            //var f95 = new List<int>() { 7, 10503 };
            //var f96 = new List<int>() { 7, 27059 };
            //var f97 = new List<int>() { 7, 151879 };
            //var f98 = new List<int>() { 7, 467126 };
            //var f99 = new List<int>() { 7, 1688926 };


            //var f100 = new List<int>() { 8, 30 };
            //var f101 = new List<int>() { 8, 28708 };
            //var f102 = new List<int>() { 8, 245108 };
            //var f103 = new List<int>() { 9, 2 };
            //var f104 = new List<int>() { 9, 6 };
            //var f105 = new List<int>() { 9, 659 };
            //var f106 = new List<int>() { 9, 1141 };
            //var f107 = new List<int>() { 9, 4538 };
            //var f108 = new List<int>() { 9, 20608 };
            //var f109 = new List<int>() { 9, 177950 };

            //var f110 = new List<int>() { 10, 20981 };
            //var f111 = new List<int>() { 11, 4 };
            //var f112 = new List<int>() { 11, 11 };
            //var f113 = new List<int>() { 11, 12 };
            //var f114 = new List<int>() { 11, 129 };
            //var f115 = new List<int>() { 11, 245 };
            //var f116 = new List<int>() { 11, 591 };
            //var f117 = new List<int>() { 11, 2772 };
            //var f118 = new List<int>() { 11, 32693 };
            //var f119 = new List<int>() { 11, 59047 };

            //var f120 = new List<int>() { 11, 277155 };
            //var f121 = new List<int>() { 11, 282160 };
            //var f122 = new List<int>() { 11, 350762 };
            //var f123 = new List<int>() { 11, 1947503 };
            //var f124 = new List<int>() { 12, 11 };
            //var f125 = new List<int>() { 12, 48 };
            //var f126 = new List<int>() { 13, 1 };
            //var f127 = new List<int>() { 13, 1 };
            //var f128 = new List<int>() { 13, 1 };
            //var f129 = new List<int>() { 13, 3 };

            //var f130 = new List<int>() { 13, 3 };
            //var f131 = new List<int>() { 13, 4 };
            //var f132 = new List<int>() { 13, 9 };
            //var f133 = new List<int>() { 13, 71 };
            //var f134 = new List<int>() { 13, 90 };
            //var f135 = new List<int>() { 13, 111 };
            //var f136 = new List<int>() { 13, 144 };
            //var f137 = new List<int>() { 13, 148 };
            //var f138 = new List<int>() { 13, 155 };
            //var f139 = new List<int>() { 13, 171 };

            //var f140 = new List<int>() { 13, 571 };
            //var f141 = new List<int>() { 13, 639 };
            //var f142 = new List<int>() { 13, 2848 };
            //var f143 = new List<int>() { 13, 4100 };
            //var f144 = new List<int>() { 13, 6019 };
            //var f145 = new List<int>() { 13, 6353 };
            //var f146 = new List<int>() { 13, 6760 };
            //var f147 = new List<int>() { 13, 9406 };
            //var f148 = new List<int>() { 13, 12418 };
            //var f149 = new List<int>() { 13, 34300 };

            //var f150 = new List<int>() { 13, 49068 };
            //var f151 = new List<int>() { 13, 52101 };
            //var f152 = new List<int>() { 13, 108365 };
            //var f153 = new List<int>() { 13, 134318 };
            //var f154 = new List<int>() { 13, 148640 };
            //var f155 = new List<int>() { 13, 208896 };
            //var f156 = new List<int>() { 13, 256107 };
            //var f157 = new List<int>() { 13, 283282 };
            //var f158 = new List<int>() { 13, 348975 };
            //var f159 = new List<int>() { 14, 5 };

            //var f160 = new List<int>() { 14, 6 };
            //var f161 = new List<int>() { 14, 31 };
            //var f162 = new List<int>() { 14, 174 };
            //var f163 = new List<int>() { 14, 279 };
            //var f164 = new List<int>() { 14, 742 };
            //var f165 = new List<int>() { 14, 3653 };
            //var f166 = new List<int>() { 14, 4259 };
            //var f167 = new List<int>() { 14, 8301 };
            //var f168 = new List<int>() { 14, 60262 };
            //var f169 = new List<int>() { 14, 99860 };

            //var f170 = new List<int>() { 14, 170858 };
            //var f171 = new List<int>() { 14, 212184 };
            //var f172 = new List<int>() { 14, 398973 };
            //var f173 = new List<int>() { 14, 413839 };



            //var marking = new List<List<int>>();
            //marking.Add(f0);
            //marking.Add(f1);
            //marking.Add(f2);
            //marking.Add(f3);
            //marking.Add(f4);
            //marking.Add(f5);
            //marking.Add(f6);
            //marking.Add(f7);
            //marking.Add(f8);
            //marking.Add(f9);

            //marking.Add(f10);
            //marking.Add(f11);
            //marking.Add(f12);
            //marking.Add(f13);
            //marking.Add(f14);
            //marking.Add(f15);
            //marking.Add(f16);
            //marking.Add(f17);
            //marking.Add(f18);
            //marking.Add(f19);

            //marking.Add(f20);
            //marking.Add(f21);
            //marking.Add(f22);
            //marking.Add(f23);
            //marking.Add(f24);
            //marking.Add(f25);
            //marking.Add(f26);
            //marking.Add(f27);
            //marking.Add(f28);
            //marking.Add(f29);

            //marking.Add(f30);
            //marking.Add(f31);
            //marking.Add(f32);
            //marking.Add(f33);
            //marking.Add(f34);
            //marking.Add(f35);
            //marking.Add(f36);
            //marking.Add(f37);
            //marking.Add(f38);
            //marking.Add(f39);

            //marking.Add(f40);
            //marking.Add(f41);
            //marking.Add(f42);
            //marking.Add(f43);
            //marking.Add(f44);
            //marking.Add(f45);
            //marking.Add(f46);
            //marking.Add(f47);
            //marking.Add(f48);
            //marking.Add(f49);

            //marking.Add(f50);
            //marking.Add(f51);
            //marking.Add(f52);
            //marking.Add(f53);
            //marking.Add(f54);
            //marking.Add(f55);
            //marking.Add(f56);
            //marking.Add(f57);
            //marking.Add(f58);
            //marking.Add(f59);

            //marking.Add(f60);
            //marking.Add(f61);
            //marking.Add(f62);
            //marking.Add(f63);
            //marking.Add(f64);
            //marking.Add(f65);
            //marking.Add(f66);
            //marking.Add(f67);
            //marking.Add(f68);
            //marking.Add(f69);

            //marking.Add(f70);
            //marking.Add(f71);
            //marking.Add(f72);
            //marking.Add(f73);
            //marking.Add(f74);
            //marking.Add(f75);
            //marking.Add(f76);
            //marking.Add(f77);
            //marking.Add(f78);
            //marking.Add(f79);

            //marking.Add(f80);
            //marking.Add(f81);
            //marking.Add(f82);
            //marking.Add(f83);
            //marking.Add(f84);
            //marking.Add(f85);
            //marking.Add(f86);
            //marking.Add(f87);
            //marking.Add(f88);
            //marking.Add(f89);

            //marking.Add(f90);
            //marking.Add(f91);
            //marking.Add(f92);
            //marking.Add(f93);
            //marking.Add(f94);
            //marking.Add(f95);
            //marking.Add(f96);
            //marking.Add(f97);
            //marking.Add(f98);
            //marking.Add(f99);

            //marking.Add(f100);
            //marking.Add(f101);
            //marking.Add(f102);
            //marking.Add(f103);
            //marking.Add(f104);
            //marking.Add(f105);
            //marking.Add(f106);
            //marking.Add(f107);
            //marking.Add(f108);
            //marking.Add(f109);

            //marking.Add(f110);
            //marking.Add(f111);
            //marking.Add(f112);
            //marking.Add(f113);
            //marking.Add(f114);
            //marking.Add(f115);
            //marking.Add(f116);
            //marking.Add(f117);
            //marking.Add(f118);
            //marking.Add(f119);

            //marking.Add(f120);
            //marking.Add(f121);
            //marking.Add(f122);
            //marking.Add(f123);
            //marking.Add(f124);
            //marking.Add(f125);
            //marking.Add(f126);
            //marking.Add(f127);
            //marking.Add(f128);
            //marking.Add(f129);

            //marking.Add(f130);
            //marking.Add(f131);
            //marking.Add(f132);
            //marking.Add(f133);
            //marking.Add(f134);
            //marking.Add(f135);
            //marking.Add(f136);
            //marking.Add(f137);
            //marking.Add(f138);
            //marking.Add(f139);

            //marking.Add(f140);
            //marking.Add(f141);
            //marking.Add(f142);
            //marking.Add(f143);
            //marking.Add(f144);
            //marking.Add(f145);
            //marking.Add(f146);
            //marking.Add(f147);
            //marking.Add(f148);
            //marking.Add(f149);

            //marking.Add(f150);
            //marking.Add(f151);
            //marking.Add(f152);
            //marking.Add(f153);
            //marking.Add(f154);
            //marking.Add(f155);
            //marking.Add(f156);
            //marking.Add(f157);
            //marking.Add(f158);
            //marking.Add(f159);

            //marking.Add(f160);
            //marking.Add(f161);
            //marking.Add(f162);
            //marking.Add(f163);
            //marking.Add(f164);
            //marking.Add(f165);
            //marking.Add(f166);
            //marking.Add(f167);
            //marking.Add(f168);
            //marking.Add(f169);

            //marking.Add(f170);
            //marking.Add(f171);
            //marking.Add(f172);
            //marking.Add(f173);
            #endregion

            //var flask = chooseFlaskSolution.chooseFlask(req, flaskType, marking);

            //var flask2 = chooseFlaskSolution.chooseFlaskBackup(req, flaskType, marking);
            //var flask2 = chooseFlaskSolution.chooseFlaskBack2(req, flaskType, marking);

            #endregion

            #region Two Sum
            //int[] word = {2, 5, 5, 11 };
            //TwoSum.TwoSu(word, 10);
            #endregion

            #region knapSack

            //int[] val = new int[] { 130, 100, 120 };
            //int[] wt = new int[] { 10, 20, 30 };
            //int W = 50;
            //int n = val.Length;

            //int result = TransactionStatement.knapSack1(W, wt, val, n);
            #endregion

            #region Calculate Profit
            ////20
            //int n = 3;
            //var earning = new List<int>() { 1, 2, 4 };
            //var cost = new List<int>() { 1, 3, 6 };
            //int e = 5;

            ////10
            //int n = 2;
            //var earning = new List<int>() { 1, 2 };
            //var cost = new List<int>() { 1, 4 };
            //int e = 5;

            ////70
            //int n = 4;
            //var earning = new List<int>() { 1, 8, 6, 7 };
            //var cost = new List<int>() { 1, 3, 4, 1 };
            //int e = 5;

            ////40
            //int n = 3;
            //var earning = new List<int>() { 7, 2, 4 };
            //var cost = new List<int>()    { 7, 3, 6 };
            //int e = 5;

            ////40
            //int n = 4;
            //var earning = new List<int>() { 7, 2, 1, 4 };
            //var cost = new List<int>() { 7, 3, 1, 6 };
            //int e = 5;

            ////36
            //int n = 3;
            //var earning = new List<int>() { 1, 5, 5 };
            //var cost = new List<int>() { 2, 1, 4 };
            //int e = 4;

            //340
            //int n = 18;
            //var earning = new List<int>() { 9, 7, 9, 2, 7, 7, 9, 6, 7, 6, 6, 3, 4, 2, 8, 4, 6, 10 };
            //var cost = new List<int>()    { 4, 1, 1, 5, 2, 3, 3, 3, 2, 4, 4, 3, 3, 4, 4, 1, 2, 5 };
            //int e = 5;

            //64860
            //int n = 98;
            //var earning = new List<int>() { 4, 2, 5, 3, 1, 5, 3, 1, 2, 5, 82, 18, 49, 99, 40, 39, 70, 25, 58, 7, 38, 36, 54, 50, 13, 27, 93, 100, 17, 72, 8, 60, 3, 99, 93, 4, 88, 80, 19, 60, 26, 100, 77, 26, 51, 68, 64, 72, 92, 73, 78, 81, 61, 84, 30, 73, 62, 74, 72, 79, 45, 31, 90, 48, 81, 82, 3, 69, 14, 73, 80, 91, 72, 8, 17, 74, 75, 80, 98, 18, 5, 27, 98, 65, 62, 79, 37, 24, 52, 60, 54, 1, 3, 3, 5, 5, 2, 2 };
            //var cost = new List<int>() { 3, 2, 4, 4, 2, 3, 3, 3, 3, 2, 5, 5, 1, 4, 4, 3, 3, 5, 1, 1, 5, 2, 5, 3, 5, 4, 3, 4, 4, 1, 3, 3, 2, 3, 4, 3, 2, 1, 3, 5, 5, 2, 1, 5, 5, 4, 3, 2, 1, 5, 2, 5, 2, 3, 5, 3, 4, 2, 1, 2, 4, 3, 1, 5, 1, 4, 4, 2, 5, 1, 3, 4, 2, 1, 3, 1, 1, 2, 4, 1, 4, 5, 1, 5, 5, 5, 4, 3, 3, 4, 1, 1, 4, 1, 5, 1, 2, 3 };
            //int e = 15;

            //660
            //int n = 11;
            //var earning = new List<int>() { 9, 9, 10, 10, 1, 2, 1, 10, 2, 4, 2 };
            //var cost = new List<int>() { 2, 4, 1, 1, 5, 1, 5, 1, 3, 5, 5 };
            //int e = 15;

            //10500
            //int n = 48;
            //var earning = new List<int>() { 5, 5, 5, 2, 3, 1, 2, 4, 3, 2, 50, 46, 32, 44, 24, 40, 15, 26, 8, 14, 6, 10, 8, 13, 26, 6, 22, 24, 40, 16, 31, 50, 12, 43, 13, 19, 33, 46, 7, 7, 33, 3, 2, 1, 4, 2, 2, 3 };
            //var cost = new List<int>() { 4, 1, 1, 4, 5, 1, 3, 1, 3, 2, 4, 3, 2, 2, 4, 3, 4, 1, 3, 3, 4, 4, 1, 3, 4, 4, 3, 2, 1, 1, 1, 1, 4, 1, 2, 3, 3, 4, 5, 1, 5, 4, 5, 3, 2, 3, 5, 2 };
            //int e = 15;

            //int result = LeadaLifeCalculateProfit.calculateProfit(n, earning, cost, e);
            //int result2 = LeadaLifeCalculateProfit.calculateProfitBackup(n, earning, cost, e);
            #endregion

            #region Fibonacci using DP
            //int number = 3;
            //int resul1 = Dynamicprogramming.NormalFib(number);
            //int resul2 = Dynamicprogramming.BottomUpFib(number);
            //int resul3 = Dynamicprogramming.TopDownFibEntry(number);
            #endregion

            #region Simple recursive program
            //int test = 3;
            //SimpleRecursivePro.printStar(test);
            #endregion

            #region Longest substring without repeating characters
            //string wordTest = "abcbacagad";
            //string wordTest = "abcbadc";
            //int maxL = LongestSubstring.longestSubstringCharacters(wordTest);
            #endregion

            #region Binary search
            //int[] seaArr = { 2, 3, 4, 10, 40 };
            //int seaResult = searching.BinarySearch(seaArr, 40);
            #endregion

            #region Selection sorting
            //int[] lst = { 4, 9, 7, 1 };
            //int[] val = Sorting.SelectionSorting(lst);
            //Console.WriteLine(val);
            #endregion

            #region Nth Ugly number
            //int result = UglyNumbers.FindNthUglyNumber(7);
            #endregion

            #region Abstract class in C#
            //TestingAbstract.Car car;

            //car = new TestingAbstract.WagonR();
            //car.getMileage();
            //Console.WriteLine($"Checking for Wagon::: {car.getIsSedan()}");

            //car = new TestingAbstract.InnovaCrysta();
            //car.getMileage();
            //Console.WriteLine($"Checking for Innova Crysta::: {car.getIsSedan()}");

            //car = new TestingAbstract.HondaCity();
            //car.getMileage();
            //Console.WriteLine($"Checking for Honda City::: {car.getIsSedan()}");
            #endregion

            #region Socks merchant
            //int[] socks = { 1, 2, 1, 2, 1, 3, 2 };
            //int[] socks = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            //int resultWays = SockMerchantSolution.sockMerchant(9, socks);
            #endregion

            #region Codility Frog Jump with leaves spread on water, get the earliest time to start jumping
            //int[] leaves = { 5, 3, 1, 4, 2, 3, 5, 4 };
            //int[] leaves = { 1 };
            //int resultWays = FrogJumpSolution.FrogJump(5, leaves);
            #endregion

            #region HackerRank Ways of reaching a number with different combinations
            //int resultWays = WaysToSumSolution.ways(5, 3);
            #endregion

            #region HackerRank Count valleys
            //string s = "UDDDUDUU";
            //string s = "DDUDDUUDUU";
            //int valley = CountingValleys.countingValleys(s.Length, s);
            #endregion

            #region HackerRank Electronic shop
            //int[] drives = { 5, 2, 8 };
            //int[] keyboards = { 3, 1 };
            //int b = 10;
            //int valley = ElectronicShop.getMoneySpent(keyboards, drives, b);
            #endregion

            #region LeetCode string compression
            //Char[] chars = { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };
            //Char[] chars = { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            //Char[] chars = { 'a' };
            //int strCom = StringCompression.Compress(chars);
            #endregion

            #region HackerRank Jumping clouds
            //int[] clounds = { 0, 1, 0, 0, 0, 1, 0 };
            //int[] clounds = { 0, 0, 0, 0, 1, 0 };
            //int[] clounds = { 0, 0, 0, 1, 0, 0 };
            //int[] clounds = { 0, 0, 1, 0, 0, 1, 0 };
            //int jump = JumpingontheClouds.jumpingOnClouds(clounds);
            #endregion

            #region Meeting room
            //int[,] rooms = { { 0, 4 }, { 5, 10 }, { 15, 20 } };
            //bool attend = MeetingRoom.Meeting(rooms);

            //int[,] rooms = { { 0, 30 }, { 15, 20 }, { 5, 10 } };
            //int[,] rooms = { { 0, 30 }, { 15, 20 }, { 10, 14 }, { 5, 9 } };
            //int[,] attend = MeetingRoom.SortMeeting(rooms);

            //int[,] rooms = { { 0, 30 }, { 15, 20 }, { 5, 10 } };
            //int[,] rooms = { { 0, 4 }, { 1, 3 }, { 5, 10 }, { 6, 9 }, { 15, 20 } };
            //int extraRoomNeeded = MeetingRoom.MeetingExtraRoom(rooms);
            #endregion

            #region Meeting room
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            //int search = searching.BinarySearch(arr, 7);
            #endregion

            #region Change coins
            //int[] arr = { 1, 2, 3};
            //int resultWays = ChangeCoin.change(10, arr);
            #endregion

            #region Find Median of Sorted Arrays WIP
            //int[] arr = { 1, 2, 3, 4, 9 };
            //int[] arr2 = { 2, 6, 8, 10, 12 };
            //int[] arr = { 1, 3 };
            //int[] arr2 = { 2};
            //int[] arr = { 1, 2 };
            //int[] arr2 = { 3, 4 };

            //double median = new FindMedian().FindMedianSortedArrays(arr, arr2);
            #endregion

            #region Hurdle race with magic potion
            //int[] arr = { 1, 6, 3, 5, 2 };
            //int curHeight = 4;

            //int[] arr = { 2, 5, 4, 5, 2 };
            //int curHeight = 7;

            //int minMagicPotion = HurdleRace.hurdleRace(curHeight, arr);
            #endregion

            #region Picking numbers
            //var arr = new List<int>() { 1, 1, 2, 2, 4, 4, 5, 5, 5};
            //var arr = new List<int>() { 4, 6, 5, 3, 3, 1 };

            //var arr = new List<int>() { 66, 66, 66, 66, 66 };
            //int max = PickingNumbers.pickingNumberReversed(arr);
            #endregion

            #region Frequency of characters e.g aabbbcd should give a2b3c1d1
            //Char[] chars = { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            //FrequencyofCharacters.Frequency(chars);
            #endregion

            #region Kth Largest number in an array
            //int[] arr = { 1, 3, 5, 6, 7 };
            //int max = KthLargestNumber.GetKthLargestNumber(arr, 8);
            #endregion

            #region Count triplets
            //var arr = new List<int>() { 66, 66, 66, 66, 66 };
            //var arr = new List<long>() { 1, 2, 2, 4 };
            //var arr = new List<long>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            //var arr = new List<long>() { 1, 1, 1, 1 };
            //var arr = new List<long>() { 1, 3, 9, 9, 27, 81 };
            //var arr = new List<long>() { 3, 3, 9, 9, 27, 81 };
            //var arr = new List<long>() { 1, 5, 5, 25, 125 };

            //long val = CountTripletNumber.countTriplets(arr, 3);
            //long val = CountTripletNumber.CountTriplets(arr, 3);

            #endregion

            #region Sorting: Bubble, Selection and Insertion
            //int[] arr = { 2, 1 };
            //int[] arr1 = { 2, 1 };
            //int[] arr2 = { 2, 1 };

            //int[] max = Sorting.SelectionSorting(arr);
            //int[] max1 = Sorting.BubbleSort(arr1);
            //int[] max2 = Sorting.InsertionSort(arr2);
            #endregion

            #region Compare triplets
            //var a = new List<int>() { 66, 66, 66, 66, 66 };
            //var b = new List<int>() { 1, 2, 2, 4 };

            //List<int> val = CompareTriplets.CompareTripletsNum(a, b);
            #endregion

            #region Repeated strings
            //string sVal = "aac";
            //long n = 6;
            //string sVal = "kmretasscityylpdhuwjirnqimlkcgxubxmsxpypgzxtenweirknjtasxtvxemtwxuarabssvqdnktqadhyktagjxoanknhgilnm";
            //long n = 10;

            //long val = RepeatedString.repeatedString(sVal, n);
            #endregion

            #region Nim game Leet code mock interview - Not passing all test
            //int n = 4;
            //bool val = NimGame.CanWinNim(n);
            #endregion

            #region Hamming Distance Leet code mock interview
            //int x = 6;
            //int y = 11;
            //int val = HammingDistance.GetHammingDistance(x, y);
            #endregion

            #region Linkedlist Add two numbers

            //LinkedList.LinkedList.SingleLinkedList node1 = new LinkedList.LinkedList.SingleLinkedList();
            //node1.AddToBegining(3);
            //node1.AddToBegining(4);
            //node1.AddToBegining(2);

            //node1.AddToBegining(8);
            //node1.AddToBegining(1);

            //node1.AddToBegining(5);


            //LinkedList.LinkedList.SingleLinkedList node2 = new LinkedList.LinkedList.SingleLinkedList();
            //node2.AddToBegining(4);
            //node2.AddToBegining(6);
            //node2.AddToBegining(5);

            //node2.AddToBegining(0);

            //node2.AddToBegining(5);

            //var result = LinkedList.Solutions.AddTwoNumbers.Add(node1.head, node2.head);

            #endregion

            #region Single number solution
            //int[] test1 = { 2, 2, 1 };
            //int[] test2 = { 4, 1, 2, 1, 2 };
            //int[] test1 = { 2, 2, 3, 1, 3 };
            //int result = SingleNumberSolution.SingleNumberSol2(test2);
            #endregion

            #region Happy number solution
            //bool result = HappyNumberSolution.IsHappy(19);
            #endregion

            #region Maximum Subset Array solution
            //int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //int maxResult = MaximumSubarraySolution.maxSubsetArray(arr);
            #endregion

            #region Move zeroes solution
            //int[] arr = { 0, 0, 1 };
            ////int[] arr = { 0, 1, 0, 3, 12 };
            //MoveZeroesSolution.MoveZeroes(arr);
            #endregion

            #region Buy and sell stocks
            //int[] arr = { 7, 1, 5, 3, 6, 4 };
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int[] arr = { 7, 6, 4, 3, 1 };
            //int result = BestTimetoBuyandSellStock.MaxProfit(arr);
            #endregion

            #region Group Anagrams
            //string[] arr = { "eat", "tea", "tan", "ate", "nat", "bat" };
            //var result = GroupAnagramsSolution.GroupAnagrams(arr);
            #endregion

            #region Counting Elements
            //int[] arr = { 1000, 2, 3 };
            //int[] arr = { 1, 1, 2, 2 };
            //int[] arr = { 1, 1, 3, 3, 5, 5, 7, 7 };
            //int[] arr = { 1, 3, 2, 3, 5, 0 };
            //int result = CountingElementsSolution.CountElements(arr);
            #endregion

            #region Middle Node

            //SingleLinkedList node = new SingleLinkedList();

            //node.head = node.AddToEnd(node.head, 1);
            //node.head = node.AddToEnd(node.head, 2);
            //node.head = node.AddToEnd(node.head, 3);
            //node.head = node.AddToEnd(node.head, 4);
            //node.head = node.AddToEnd(node.head, 5);

            //node.head = node.AddToEnd(node.head, 1);
            //node.head = node.AddToEnd(node.head, 2);
            //node.head = node.AddToEnd(node.head, 3);
            //node.head = node.AddToEnd(node.head, 4);
            //node.head = node.AddToEnd(node.head, 5);
            //node.head = node.AddToEnd(node.head, 6);

            //var result = new MiddleNodeSolution().CountElements(node.head);

            #endregion

            #region Group Anagrams
            //string S = "ab#c";
            //string T = "ad#c";
            //string S = "ab##";
            //string T = "c#d#";
            //string S = "a##c";
            //string T = "#a#c";
            //string S = "a#c";
            //string T = "b";
            //var result = BackspaceStringCompare.BackspaceCompare(S,T);
            #endregion

            #region Mini stack
            //MinStack minStack = new MinStack();
            //minStack.Push(-2);
            //minStack.Push(0);
            //minStack.Push(-3);
            //int result = minStack.GetMin(); //--> Returns - 3.
            //minStack.Pop();
            //int result2 = minStack.Top(); //--> Returns 0.
            //int result3 = minStack.GetMin(); //--> Returns - 2.
            #endregion

            #region Diameter of Binary Tree
            //TreeNode tree = Leetcodechallenge.Day11.BinarySearchTree.CreateNewNode(1);
            //tree.left = Leetcodechallenge.Day11.BinarySearchTree.CreateNewNode(2);
            //tree.right = Leetcodechallenge.Day11.BinarySearchTree.CreateNewNode(3);
            //tree.left.left = Leetcodechallenge.Day11.BinarySearchTree.CreateNewNode(4);
            //tree.left.right = Leetcodechallenge.Day11.BinarySearchTree.CreateNewNode(5);

            ////tree.left.right.left = Leetcodechallenge.Day11.BinarySearchTree.CreateNewNode(6);
            ////tree.left.right.right = Leetcodechallenge.Day11.BinarySearchTree.CreateNewNode(7);

            ////tree.left = Leetcodechallenge.Day11.BinarySearchTree.CreateNewNode(1);
            ////tree.right = Leetcodechallenge.Day11.BinarySearchTree.CreateNewNode(4);
            ////tree.left.left = Leetcodechallenge.Day11.BinarySearchTree.CreateNewNode(3);
            ////tree.right.left = Leetcodechallenge.Day11.BinarySearchTree.CreateNewNode(5);
            ////tree.left.right = Leetcodechallenge.Day11.BinarySearchTree.CreateNewNode(5);
            ////tree.left.left.right = Leetcodechallenge.Day11.BinarySearchTree.CreateNewNode(4);
            ////tree.left.left.left = Leetcodechallenge.Day11.BinarySearchTree.CreateNewNode(5);

            //int output = Leetcodechallenge.Day11.DiameterofBinaryTree.DiameterOfBinaryTree(tree);
            #endregion

            #region Last Stone Weight Solution
            //int[] arr = { 2, 7, 4, 1, 8, 1 };
            //int[] arr = { 1 };
            //var result = LastStoneWeightSolution.LastStoneWeight(arr);
            #endregion

            #region FindMinFibonacciNumbers Solution
            //Leetcode challenge
            //var result = FindMinFibonacciNumbersSolution.FindMinFibonacciNumbers(3);
            #endregion

            #region SearchinRotatedSortedArray Solution
            //int[] arr = { 4, 5, 6, 7, 0, 1, 2 };
            //int target = 0;
            //int target = 3;
            //var result = SearchinRotatedSortedArray.Search(arr, target);
            #endregion

            #region Contiguous Array
            ////int[] arr = { 0, 1 };
            ////int[] arr = { 0, 1, 0 };
            ////int[] arr = { 0, 1, 0, 1};
            //int[] arr = {0,1,1,0,1,1,1,0 };
            //var result = ContiguousArray.FindMaxLength(arr);
            #endregion

            #region String shift
            //string s = "abc";
            //int[,] arr = { { 0, 1 }, { 1, 2 }};

            //string s = "abcdefg";
            //int[,] arr = { { 1, 1 }, { 1, 1 }, { 0, 2 }, { 1, 3 } };
            //var result = PerformStringShifts.StringShift(s, arr);

            //string s = "( () ) (( () ) () () (* ) (* () ( () ) () )())()()((()())((()))(*";
            //string s = "()";
            //string s = "(*)";
            //string s = "(*))";
            //string s = "(*)))";
            //string s = "((****)))";
            //var result = PerformStringShifts.CheckValidString(s);

            #endregion

            #region Binary Search Tree from Preorder Traversal
            //int[] arr = { 8, 5, 1, 7, 10, 12 };
            //var result = BinarySearchTreefromPreorderTraversal.BstFromPreorder(arr);
            #endregion

            #region Subarray Sum Equals K
            //int[] arr = { 1, 1, 1 };
            //int[] arr = { 1, 1, 2, 3, 4 };
            //var result = SubarraySumEqualsK.SubarraySum(arr, 6);
            #endregion

            #region Jump game solution
            //int[] arr = { 2, 2, 1, 1, 4 };
            //int[] arr = { 4, 2, 1, 0, 4 };
            //int[] arr = { 3, 2, 1, 0, 4 };
            //int[] arr = { 0, 2, 1, 1, 4 };
            //int[] arr = { 1, 0, 1, 0 };
            //int[] arr = { 1, 0, 2 };
            //int[] arr = { 1, 0, 0, 2 };
            //int[] arr = { 2, 0, 1, 2 };
            //int[] arr = { 3, 0, 8, 2, 0, 0, 1 };
            //int[] arr = { 5, 9, 3, 2, 1, 0, 2, 3, 2, 1, 0, 0 };
            //var result = JumpGameSolution.CanJump(arr);
            #endregion

            #region Weekly Contest
            //int[] arr = { 2, 2, 1, 1, 4 };
            //int[] arr = { 4, 2, 1, 0, 4 };
            //int[] arr = { 3, 2, 1, 0, 4 };
            //int[] arr = { 0, 2, 1, 1, 4 };
            //int[] arr = { 1, 0, 1, 0 };
            //int[] arr = { 1, 0, 2 };
            //int[] arr = { 1, 0, 0, 2 };
            //int[] arr = { 2, 0, 1, 2 };
            //int[] arr = { 9, 7, 7, 9, 7, 7, 9 };
            ////int[] arr = { 100, 40, 17, 9, 73, 75 };
            //var result = Week186Solution.MaxScore(arr, 3);

            //var result1 = Week186Solution.MaxScore1("00111");
            #endregion

            #region ImageEditing
            //var list1 = new List<int>() { 1, 0, 1, 1, 1 };
            //var list2 = new List<int>() { 1, 0, 1, 1, 0 };
            //var list3 = new List<int>() { 1, 1, 1, 1, 0 };
            //var list4 = new List<int>() { 1, 1, 1, 1, 0 };
            //var list5 = new List<int>() { 1, 1, 1, 1, 1 };
            //var numbers = new List<List<int>>();
            //numbers.Add(list1);
            //numbers.Add(list2);
            //numbers.Add(list3);
            //numbers.Add(list4);
            //numbers.Add(list5);
            //int result = ImageEditing.largestMatrix(numbers);
            #endregion

            #region Maximal Square Solution
            //char[,] arr = { { '1', '0', '1', '0', '0' }, { '1', '0', '1', '1', '1' }, { '1', '1', '1', '1', '1' }, { '1', '0', '0', '1', '0' } };
            //char[,] arr = { };
            //var result = MaximalSquareSolution.MaximalSquare(arr);
            #endregion

            #region Jewels and Stones Solution
            //string J = "aA";
            //string S = "aAAbbbb";
            ////string J = "z";
            ////string S = "ZZ";
            //var result = JewelsandStonesSolution.NumJewelsInStonesSol2(J, S);
            #endregion

            #region First Bad Version Solution
            var result = FirstBadVersionSolution.FirstBadVersion(5);
            #endregion


            Console.ReadLine();
        }
    }
}
