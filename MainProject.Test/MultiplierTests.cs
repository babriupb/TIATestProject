using System.Threading;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
	[TestClass]
	public class MultiplierTests
	{
		[TestInitialize]
		public void InitTestcase()
		{
			Thread.Sleep(100);
		}

		[TestMethod]
		public void MultiplyFloatTest1()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(1, 1);
			Assert.AreEqual(1, result);
		}
		[TestMethod]
		public void MultiplyFloatTest2()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(2, 2);
			Assert.AreEqual(4, result);
		}
		[TestMethod]
		public void MultiplyFloatTest3()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(3, 3);
			Assert.AreEqual(9, result);
		}
		[TestMethod]
		public void MultiplyFloatTest4()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(4, 4);
			Assert.AreEqual(16, result);
		}
		[TestMethod]
		public void MultiplyFloatTest5()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(5, 5);
			Assert.AreEqual(25, result);
		}
		[TestMethod]
		public void MultiplyFloatTest6()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(6, 6);
			Assert.AreEqual(36, result);
		}
		[TestMethod]
		public void MultiplyFloatTest7()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(7, 7);
			Assert.AreEqual(49, result);
		}
		[TestMethod]
		public void MultiplyFloatTest8()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(8, 8);
			Assert.AreEqual(64, result);
		}
		[TestMethod]
		public void MultiplyFloatTest9()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(9, 9);
			Assert.AreEqual(81, result);
		}
		[TestMethod]
		public void MultiplyFloatTest10()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(10, 10);
			Assert.AreEqual(100, result);
		}
		[TestMethod]
		public void MultiplyFloatTest11()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(11, 11);
			Assert.AreEqual(121, result);
		}
		[TestMethod]
		public void MultiplyFloatTest12()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(12, 12);
			Assert.AreEqual(144, result);
		}
		[TestMethod]
		public void MultiplyFloatTest13()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(13, 13);
			Assert.AreEqual(169, result);
		}
		[TestMethod]
		public void MultiplyFloatTest14()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(14, 14);
			Assert.AreEqual(196, result);
		}
		[TestMethod]
		public void MultiplyFloatTest15()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(15, 15);
			Assert.AreEqual(225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest16()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(16, 16);
			Assert.AreEqual(256, result);
		}
		[TestMethod]
		public void MultiplyFloatTest17()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(17, 17);
			Assert.AreEqual(289, result);
		}
		[TestMethod]
		public void MultiplyFloatTest18()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(18, 18);
			Assert.AreEqual(324, result);
		}
		[TestMethod]
		public void MultiplyFloatTest19()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(19, 19);
			Assert.AreEqual(361, result);
		}
		[TestMethod]
		public void MultiplyFloatTest20()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(20, 20);
			Assert.AreEqual(400, result);
		}
		[TestMethod]
		public void MultiplyFloatTest21()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(21, 21);
			Assert.AreEqual(441, result);
		}
		[TestMethod]
		public void MultiplyFloatTest22()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(22, 22);
			Assert.AreEqual(484, result);
		}
		[TestMethod]
		public void MultiplyFloatTest23()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(23, 23);
			Assert.AreEqual(529, result);
		}
		[TestMethod]
		public void MultiplyFloatTest24()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(24, 24);
			Assert.AreEqual(576, result);
		}
		[TestMethod]
		public void MultiplyFloatTest25()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(25, 25);
			Assert.AreEqual(625, result);
		}
		[TestMethod]
		public void MultiplyFloatTest26()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(26, 26);
			Assert.AreEqual(676, result);
		}
		[TestMethod]
		public void MultiplyFloatTest27()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(27, 27);
			Assert.AreEqual(729, result);
		}
		[TestMethod]
		public void MultiplyFloatTest28()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(28, 28);
			Assert.AreEqual(784, result);
		}
		[TestMethod]
		public void MultiplyFloatTest29()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(29, 29);
			Assert.AreEqual(841, result);
		}
		[TestMethod]
		public void MultiplyFloatTest30()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(30, 30);
			Assert.AreEqual(900, result);
		}
		[TestMethod]
		public void MultiplyFloatTest31()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(31, 31);
			Assert.AreEqual(961, result);
		}
		[TestMethod]
		public void MultiplyFloatTest32()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(32, 32);
			Assert.AreEqual(1024, result);
		}
		[TestMethod]
		public void MultiplyFloatTest33()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(33, 33);
			Assert.AreEqual(1089, result);
		}
		[TestMethod]
		public void MultiplyFloatTest34()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(34, 34);
			Assert.AreEqual(1156, result);
		}
		[TestMethod]
		public void MultiplyFloatTest35()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(35, 35);
			Assert.AreEqual(1225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest36()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(36, 36);
			Assert.AreEqual(1296, result);
		}
		[TestMethod]
		public void MultiplyFloatTest37()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(37, 37);
			Assert.AreEqual(1369, result);
		}
		[TestMethod]
		public void MultiplyFloatTest38()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(38, 38);
			Assert.AreEqual(1444, result);
		}
		[TestMethod]
		public void MultiplyFloatTest39()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(39, 39);
			Assert.AreEqual(1521, result);
		}
		[TestMethod]
		public void MultiplyFloatTest40()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(40, 40);
			Assert.AreEqual(1600, result);
		}
		[TestMethod]
		public void MultiplyFloatTest41()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(41, 41);
			Assert.AreEqual(1681, result);
		}
		[TestMethod]
		public void MultiplyFloatTest42()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(42, 42);
			Assert.AreEqual(1764, result);
		}
		[TestMethod]
		public void MultiplyFloatTest43()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(43, 43);
			Assert.AreEqual(1849, result);
		}
		[TestMethod]
		public void MultiplyFloatTest44()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(44, 44);
			Assert.AreEqual(1936, result);
		}
		[TestMethod]
		public void MultiplyFloatTest45()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(45, 45);
			Assert.AreEqual(2025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest46()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(46, 46);
			Assert.AreEqual(2116, result);
		}
		[TestMethod]
		public void MultiplyFloatTest47()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(47, 47);
			Assert.AreEqual(2209, result);
		}
		[TestMethod]
		public void MultiplyFloatTest48()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(48, 48);
			Assert.AreEqual(2304, result);
		}
		[TestMethod]
		public void MultiplyFloatTest49()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(49, 49);
			Assert.AreEqual(2401, result);
		}
		[TestMethod]
		public void MultiplyFloatTest50()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(50, 50);
			Assert.AreEqual(2500, result);
		}
		[TestMethod]
		public void MultiplyFloatTest51()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(51, 51);
			Assert.AreEqual(2601, result);
		}
		[TestMethod]
		public void MultiplyFloatTest52()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(52, 52);
			Assert.AreEqual(2704, result);
		}
		[TestMethod]
		public void MultiplyFloatTest53()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(53, 53);
			Assert.AreEqual(2809, result);
		}
		[TestMethod]
		public void MultiplyFloatTest54()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(54, 54);
			Assert.AreEqual(2916, result);
		}
		[TestMethod]
		public void MultiplyFloatTest55()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(55, 55);
			Assert.AreEqual(3025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest56()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(56, 56);
			Assert.AreEqual(3136, result);
		}
		[TestMethod]
		public void MultiplyFloatTest57()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(57, 57);
			Assert.AreEqual(3249, result);
		}
		[TestMethod]
		public void MultiplyFloatTest58()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(58, 58);
			Assert.AreEqual(3364, result);
		}
		[TestMethod]
		public void MultiplyFloatTest59()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(59, 59);
			Assert.AreEqual(3481, result);
		}
		[TestMethod]
		public void MultiplyFloatTest60()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(60, 60);
			Assert.AreEqual(3600, result);
		}
		[TestMethod]
		public void MultiplyFloatTest61()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(61, 61);
			Assert.AreEqual(3721, result);
		}
		[TestMethod]
		public void MultiplyFloatTest62()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(62, 62);
			Assert.AreEqual(3844, result);
		}
		[TestMethod]
		public void MultiplyFloatTest63()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(63, 63);
			Assert.AreEqual(3969, result);
		}
		[TestMethod]
		public void MultiplyFloatTest64()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(64, 64);
			Assert.AreEqual(4096, result);
		}
		[TestMethod]
		public void MultiplyFloatTest65()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(65, 65);
			Assert.AreEqual(4225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest66()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(66, 66);
			Assert.AreEqual(4356, result);
		}
		[TestMethod]
		public void MultiplyFloatTest67()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(67, 67);
			Assert.AreEqual(4489, result);
		}
		[TestMethod]
		public void MultiplyFloatTest68()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(68, 68);
			Assert.AreEqual(4624, result);
		}
		[TestMethod]
		public void MultiplyFloatTest69()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(69, 69);
			Assert.AreEqual(4761, result);
		}
		[TestMethod]
		public void MultiplyFloatTest70()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(70, 70);
			Assert.AreEqual(4900, result);
		}
		[TestMethod]
		public void MultiplyFloatTest71()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(71, 71);
			Assert.AreEqual(5041, result);
		}
		[TestMethod]
		public void MultiplyFloatTest72()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(72, 72);
			Assert.AreEqual(5184, result);
		}
		[TestMethod]
		public void MultiplyFloatTest73()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(73, 73);
			Assert.AreEqual(5329, result);
		}
		[TestMethod]
		public void MultiplyFloatTest74()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(74, 74);
			Assert.AreEqual(5476, result);
		}
		[TestMethod]
		public void MultiplyFloatTest75()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(75, 75);
			Assert.AreEqual(5625, result);
		}
		[TestMethod]
		public void MultiplyFloatTest76()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(76, 76);
			Assert.AreEqual(5776, result);
		}
		[TestMethod]
		public void MultiplyFloatTest77()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(77, 77);
			Assert.AreEqual(5929, result);
		}
		[TestMethod]
		public void MultiplyFloatTest78()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(78, 78);
			Assert.AreEqual(6084, result);
		}
		[TestMethod]
		public void MultiplyFloatTest79()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(79, 79);
			Assert.AreEqual(6241, result);
		}
		[TestMethod]
		public void MultiplyFloatTest80()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(80, 80);
			Assert.AreEqual(6400, result);
		}
		[TestMethod]
		public void MultiplyFloatTest81()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(81, 81);
			Assert.AreEqual(6561, result);
		}
		[TestMethod]
		public void MultiplyFloatTest82()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(82, 82);
			Assert.AreEqual(6724, result);
		}
		[TestMethod]
		public void MultiplyFloatTest83()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(83, 83);
			Assert.AreEqual(6889, result);
		}
		[TestMethod]
		public void MultiplyFloatTest84()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(84, 84);
			Assert.AreEqual(7056, result);
		}
		[TestMethod]
		public void MultiplyFloatTest85()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(85, 85);
			Assert.AreEqual(7225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest86()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(86, 86);
			Assert.AreEqual(7396, result);
		}
		[TestMethod]
		public void MultiplyFloatTest87()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(87, 87);
			Assert.AreEqual(7569, result);
		}
		[TestMethod]
		public void MultiplyFloatTest88()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(88, 88);
			Assert.AreEqual(7744, result);
		}
		[TestMethod]
		public void MultiplyFloatTest89()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(89, 89);
			Assert.AreEqual(7921, result);
		}
		[TestMethod]
		public void MultiplyFloatTest90()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(90, 90);
			Assert.AreEqual(8100, result);
		}
		[TestMethod]
		public void MultiplyFloatTest91()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(91, 91);
			Assert.AreEqual(8281, result);
		}
		[TestMethod]
		public void MultiplyFloatTest92()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(92, 92);
			Assert.AreEqual(8464, result);
		}
		[TestMethod]
		public void MultiplyFloatTest93()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(93, 93);
			Assert.AreEqual(8649, result);
		}
		[TestMethod]
		public void MultiplyFloatTest94()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(94, 94);
			Assert.AreEqual(8836, result);
		}
		[TestMethod]
		public void MultiplyFloatTest95()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(95, 95);
			Assert.AreEqual(9025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest96()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(96, 96);
			Assert.AreEqual(9216, result);
		}
		[TestMethod]
		public void MultiplyFloatTest97()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(97, 97);
			Assert.AreEqual(9409, result);
		}
		[TestMethod]
		public void MultiplyFloatTest98()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(98, 98);
			Assert.AreEqual(9604, result);
		}
		[TestMethod]
		public void MultiplyFloatTest99()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(99, 99);
			Assert.AreEqual(9801, result);
		}
		[TestMethod]
		public void MultiplyFloatTest100()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(100, 100);
			Assert.AreEqual(10000, result);
		}
		[TestMethod]
		public void MultiplyFloatTest101()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(101, 101);
			Assert.AreEqual(10201, result);
		}
		[TestMethod]
		public void MultiplyFloatTest102()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(102, 102);
			Assert.AreEqual(10404, result);
		}
		[TestMethod]
		public void MultiplyFloatTest103()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(103, 103);
			Assert.AreEqual(10609, result);
		}
		[TestMethod]
		public void MultiplyFloatTest104()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(104, 104);
			Assert.AreEqual(10816, result);
		}
		[TestMethod]
		public void MultiplyFloatTest105()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(105, 105);
			Assert.AreEqual(11025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest106()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(106, 106);
			Assert.AreEqual(11236, result);
		}
		[TestMethod]
		public void MultiplyFloatTest107()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(107, 107);
			Assert.AreEqual(11449, result);
		}
		[TestMethod]
		public void MultiplyFloatTest108()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(108, 108);
			Assert.AreEqual(11664, result);
		}
		[TestMethod]
		public void MultiplyFloatTest109()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(109, 109);
			Assert.AreEqual(11881, result);
		}
		[TestMethod]
		public void MultiplyFloatTest110()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(110, 110);
			Assert.AreEqual(12100, result);
		}
		[TestMethod]
		public void MultiplyFloatTest111()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(111, 111);
			Assert.AreEqual(12321, result);
		}
		[TestMethod]
		public void MultiplyFloatTest112()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(112, 112);
			Assert.AreEqual(12544, result);
		}
		[TestMethod]
		public void MultiplyFloatTest113()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(113, 113);
			Assert.AreEqual(12769, result);
		}
		[TestMethod]
		public void MultiplyFloatTest114()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(114, 114);
			Assert.AreEqual(12996, result);
		}
		[TestMethod]
		public void MultiplyFloatTest115()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(115, 115);
			Assert.AreEqual(13225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest116()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(116, 116);
			Assert.AreEqual(13456, result);
		}
		[TestMethod]
		public void MultiplyFloatTest117()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(117, 117);
			Assert.AreEqual(13689, result);
		}
		[TestMethod]
		public void MultiplyFloatTest118()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(118, 118);
			Assert.AreEqual(13924, result);
		}
		[TestMethod]
		public void MultiplyFloatTest119()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(119, 119);
			Assert.AreEqual(14161, result);
		}
		[TestMethod]
		public void MultiplyFloatTest120()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(120, 120);
			Assert.AreEqual(14400, result);
		}
		[TestMethod]
		public void MultiplyFloatTest121()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(121, 121);
			Assert.AreEqual(14641, result);
		}
		[TestMethod]
		public void MultiplyFloatTest122()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(122, 122);
			Assert.AreEqual(14884, result);
		}
		[TestMethod]
		public void MultiplyFloatTest123()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(123, 123);
			Assert.AreEqual(15129, result);
		}
		[TestMethod]
		public void MultiplyFloatTest124()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(124, 124);
			Assert.AreEqual(15376, result);
		}
		[TestMethod]
		public void MultiplyFloatTest125()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(125, 125);
			Assert.AreEqual(15625, result);
		}
		[TestMethod]
		public void MultiplyFloatTest126()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(126, 126);
			Assert.AreEqual(15876, result);
		}
		[TestMethod]
		public void MultiplyFloatTest127()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(127, 127);
			Assert.AreEqual(16129, result);
		}
		[TestMethod]
		public void MultiplyFloatTest128()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(128, 128);
			Assert.AreEqual(16384, result);
		}
		[TestMethod]
		public void MultiplyFloatTest129()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(129, 129);
			Assert.AreEqual(16641, result);
		}
		[TestMethod]
		public void MultiplyFloatTest130()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(130, 130);
			Assert.AreEqual(16900, result);
		}
		[TestMethod]
		public void MultiplyFloatTest131()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(131, 131);
			Assert.AreEqual(17161, result);
		}
		[TestMethod]
		public void MultiplyFloatTest132()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(132, 132);
			Assert.AreEqual(17424, result);
		}
		[TestMethod]
		public void MultiplyFloatTest133()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(133, 133);
			Assert.AreEqual(17689, result);
		}
		[TestMethod]
		public void MultiplyFloatTest134()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(134, 134);
			Assert.AreEqual(17956, result);
		}
		[TestMethod]
		public void MultiplyFloatTest135()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(135, 135);
			Assert.AreEqual(18225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest136()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(136, 136);
			Assert.AreEqual(18496, result);
		}
		[TestMethod]
		public void MultiplyFloatTest137()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(137, 137);
			Assert.AreEqual(18769, result);
		}
		[TestMethod]
		public void MultiplyFloatTest138()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(138, 138);
			Assert.AreEqual(19044, result);
		}
		[TestMethod]
		public void MultiplyFloatTest139()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(139, 139);
			Assert.AreEqual(19321, result);
		}
		[TestMethod]
		public void MultiplyFloatTest140()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(140, 140);
			Assert.AreEqual(19600, result);
		}
		[TestMethod]
		public void MultiplyFloatTest141()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(141, 141);
			Assert.AreEqual(19881, result);
		}
		[TestMethod]
		public void MultiplyFloatTest142()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(142, 142);
			Assert.AreEqual(20164, result);
		}
		[TestMethod]
		public void MultiplyFloatTest143()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(143, 143);
			Assert.AreEqual(20449, result);
		}
		[TestMethod]
		public void MultiplyFloatTest144()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(144, 144);
			Assert.AreEqual(20736, result);
		}
		[TestMethod]
		public void MultiplyFloatTest145()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(145, 145);
			Assert.AreEqual(21025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest146()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(146, 146);
			Assert.AreEqual(21316, result);
		}
		[TestMethod]
		public void MultiplyFloatTest147()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(147, 147);
			Assert.AreEqual(21609, result);
		}
		[TestMethod]
		public void MultiplyFloatTest148()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(148, 148);
			Assert.AreEqual(21904, result);
		}
		[TestMethod]
		public void MultiplyFloatTest149()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(149, 149);
			Assert.AreEqual(22201, result);
		}
		[TestMethod]
		public void MultiplyFloatTest150()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(150, 150);
			Assert.AreEqual(22500, result);
		}
		[TestMethod]
		public void MultiplyFloatTest151()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(151, 151);
			Assert.AreEqual(22801, result);
		}
		[TestMethod]
		public void MultiplyFloatTest152()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(152, 152);
			Assert.AreEqual(23104, result);
		}
		[TestMethod]
		public void MultiplyFloatTest153()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(153, 153);
			Assert.AreEqual(23409, result);
		}
		[TestMethod]
		public void MultiplyFloatTest154()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(154, 154);
			Assert.AreEqual(23716, result);
		}
		[TestMethod]
		public void MultiplyFloatTest155()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(155, 155);
			Assert.AreEqual(24025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest156()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(156, 156);
			Assert.AreEqual(24336, result);
		}
		[TestMethod]
		public void MultiplyFloatTest157()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(157, 157);
			Assert.AreEqual(24649, result);
		}
		[TestMethod]
		public void MultiplyFloatTest158()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(158, 158);
			Assert.AreEqual(24964, result);
		}
		[TestMethod]
		public void MultiplyFloatTest159()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(159, 159);
			Assert.AreEqual(25281, result);
		}
		[TestMethod]
		public void MultiplyFloatTest160()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(160, 160);
			Assert.AreEqual(25600, result);
		}
		[TestMethod]
		public void MultiplyFloatTest161()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(161, 161);
			Assert.AreEqual(25921, result);
		}
		[TestMethod]
		public void MultiplyFloatTest162()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(162, 162);
			Assert.AreEqual(26244, result);
		}
		[TestMethod]
		public void MultiplyFloatTest163()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(163, 163);
			Assert.AreEqual(26569, result);
		}
		[TestMethod]
		public void MultiplyFloatTest164()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(164, 164);
			Assert.AreEqual(26896, result);
		}
		[TestMethod]
		public void MultiplyFloatTest165()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(165, 165);
			Assert.AreEqual(27225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest166()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(166, 166);
			Assert.AreEqual(27556, result);
		}
		[TestMethod]
		public void MultiplyFloatTest167()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(167, 167);
			Assert.AreEqual(27889, result);
		}
		[TestMethod]
		public void MultiplyFloatTest168()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(168, 168);
			Assert.AreEqual(28224, result);
		}
		[TestMethod]
		public void MultiplyFloatTest169()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(169, 169);
			Assert.AreEqual(28561, result);
		}
		[TestMethod]
		public void MultiplyFloatTest170()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(170, 170);
			Assert.AreEqual(28900, result);
		}
		[TestMethod]
		public void MultiplyFloatTest171()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(171, 171);
			Assert.AreEqual(29241, result);
		}
		[TestMethod]
		public void MultiplyFloatTest172()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(172, 172);
			Assert.AreEqual(29584, result);
		}
		[TestMethod]
		public void MultiplyFloatTest173()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(173, 173);
			Assert.AreEqual(29929, result);
		}
		[TestMethod]
		public void MultiplyFloatTest174()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(174, 174);
			Assert.AreEqual(30276, result);
		}
		[TestMethod]
		public void MultiplyFloatTest175()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(175, 175);
			Assert.AreEqual(30625, result);
		}
		[TestMethod]
		public void MultiplyFloatTest176()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(176, 176);
			Assert.AreEqual(30976, result);
		}
		[TestMethod]
		public void MultiplyFloatTest177()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(177, 177);
			Assert.AreEqual(31329, result);
		}
		[TestMethod]
		public void MultiplyFloatTest178()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(178, 178);
			Assert.AreEqual(31684, result);
		}
		[TestMethod]
		public void MultiplyFloatTest179()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(179, 179);
			Assert.AreEqual(32041, result);
		}
		[TestMethod]
		public void MultiplyFloatTest180()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(180, 180);
			Assert.AreEqual(32400, result);
		}
		[TestMethod]
		public void MultiplyFloatTest181()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(181, 181);
			Assert.AreEqual(32761, result);
		}
		[TestMethod]
		public void MultiplyFloatTest182()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(182, 182);
			Assert.AreEqual(33124, result);
		}
		[TestMethod]
		public void MultiplyFloatTest183()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(183, 183);
			Assert.AreEqual(33489, result);
		}
		[TestMethod]
		public void MultiplyFloatTest184()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(184, 184);
			Assert.AreEqual(33856, result);
		}
		[TestMethod]
		public void MultiplyFloatTest185()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(185, 185);
			Assert.AreEqual(34225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest186()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(186, 186);
			Assert.AreEqual(34596, result);
		}
		[TestMethod]
		public void MultiplyFloatTest187()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(187, 187);
			Assert.AreEqual(34969, result);
		}
		[TestMethod]
		public void MultiplyFloatTest188()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(188, 188);
			Assert.AreEqual(35344, result);
		}
		[TestMethod]
		public void MultiplyFloatTest189()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(189, 189);
			Assert.AreEqual(35721, result);
		}
		[TestMethod]
		public void MultiplyFloatTest190()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(190, 190);
			Assert.AreEqual(36100, result);
		}
		[TestMethod]
		public void MultiplyFloatTest191()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(191, 191);
			Assert.AreEqual(36481, result);
		}
		[TestMethod]
		public void MultiplyFloatTest192()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(192, 192);
			Assert.AreEqual(36864, result);
		}
		[TestMethod]
		public void MultiplyFloatTest193()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(193, 193);
			Assert.AreEqual(37249, result);
		}
		[TestMethod]
		public void MultiplyFloatTest194()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(194, 194);
			Assert.AreEqual(37636, result);
		}
		[TestMethod]
		public void MultiplyFloatTest195()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(195, 195);
			Assert.AreEqual(38025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest196()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(196, 196);
			Assert.AreEqual(38416, result);
		}
		[TestMethod]
		public void MultiplyFloatTest197()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(197, 197);
			Assert.AreEqual(38809, result);
		}
		[TestMethod]
		public void MultiplyFloatTest198()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(198, 198);
			Assert.AreEqual(39204, result);
		}
		[TestMethod]
		public void MultiplyFloatTest199()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(199, 199);
			Assert.AreEqual(39601, result);
		}
		[TestMethod]
		public void MultiplyFloatTest200()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(200, 200);
			Assert.AreEqual(40000, result);
		}
		[TestMethod]
		public void MultiplyFloatTest201()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(201, 201);
			Assert.AreEqual(40401, result);
		}
		[TestMethod]
		public void MultiplyFloatTest202()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(202, 202);
			Assert.AreEqual(40804, result);
		}
		[TestMethod]
		public void MultiplyFloatTest203()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(203, 203);
			Assert.AreEqual(41209, result);
		}
		[TestMethod]
		public void MultiplyFloatTest204()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(204, 204);
			Assert.AreEqual(41616, result);
		}
		[TestMethod]
		public void MultiplyFloatTest205()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(205, 205);
			Assert.AreEqual(42025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest206()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(206, 206);
			Assert.AreEqual(42436, result);
		}
		[TestMethod]
		public void MultiplyFloatTest207()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(207, 207);
			Assert.AreEqual(42849, result);
		}
		[TestMethod]
		public void MultiplyFloatTest208()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(208, 208);
			Assert.AreEqual(43264, result);
		}
		[TestMethod]
		public void MultiplyFloatTest209()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(209, 209);
			Assert.AreEqual(43681, result);
		}
		[TestMethod]
		public void MultiplyFloatTest210()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(210, 210);
			Assert.AreEqual(44100, result);
		}
		[TestMethod]
		public void MultiplyFloatTest211()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(211, 211);
			Assert.AreEqual(44521, result);
		}
		[TestMethod]
		public void MultiplyFloatTest212()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(212, 212);
			Assert.AreEqual(44944, result);
		}
		[TestMethod]
		public void MultiplyFloatTest213()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(213, 213);
			Assert.AreEqual(45369, result);
		}
		[TestMethod]
		public void MultiplyFloatTest214()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(214, 214);
			Assert.AreEqual(45796, result);
		}
		[TestMethod]
		public void MultiplyFloatTest215()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(215, 215);
			Assert.AreEqual(46225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest216()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(216, 216);
			Assert.AreEqual(46656, result);
		}
		[TestMethod]
		public void MultiplyFloatTest217()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(217, 217);
			Assert.AreEqual(47089, result);
		}
		[TestMethod]
		public void MultiplyFloatTest218()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(218, 218);
			Assert.AreEqual(47524, result);
		}
		[TestMethod]
		public void MultiplyFloatTest219()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(219, 219);
			Assert.AreEqual(47961, result);
		}
		[TestMethod]
		public void MultiplyFloatTest220()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(220, 220);
			Assert.AreEqual(48400, result);
		}
		[TestMethod]
		public void MultiplyFloatTest221()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(221, 221);
			Assert.AreEqual(48841, result);
		}
		[TestMethod]
		public void MultiplyFloatTest222()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(222, 222);
			Assert.AreEqual(49284, result);
		}
		[TestMethod]
		public void MultiplyFloatTest223()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(223, 223);
			Assert.AreEqual(49729, result);
		}
		[TestMethod]
		public void MultiplyFloatTest224()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(224, 224);
			Assert.AreEqual(50176, result);
		}
		[TestMethod]
		public void MultiplyFloatTest225()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(225, 225);
			Assert.AreEqual(50625, result);
		}
		[TestMethod]
		public void MultiplyFloatTest226()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(226, 226);
			Assert.AreEqual(51076, result);
		}
		[TestMethod]
		public void MultiplyFloatTest227()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(227, 227);
			Assert.AreEqual(51529, result);
		}
		[TestMethod]
		public void MultiplyFloatTest228()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(228, 228);
			Assert.AreEqual(51984, result);
		}
		[TestMethod]
		public void MultiplyFloatTest229()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(229, 229);
			Assert.AreEqual(52441, result);
		}
		[TestMethod]
		public void MultiplyFloatTest230()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(230, 230);
			Assert.AreEqual(52900, result);
		}
		[TestMethod]
		public void MultiplyFloatTest231()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(231, 231);
			Assert.AreEqual(53361, result);
		}
		[TestMethod]
		public void MultiplyFloatTest232()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(232, 232);
			Assert.AreEqual(53824, result);
		}
		[TestMethod]
		public void MultiplyFloatTest233()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(233, 233);
			Assert.AreEqual(54289, result);
		}
		[TestMethod]
		public void MultiplyFloatTest234()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(234, 234);
			Assert.AreEqual(54756, result);
		}
		[TestMethod]
		public void MultiplyFloatTest235()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(235, 235);
			Assert.AreEqual(55225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest236()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(236, 236);
			Assert.AreEqual(55696, result);
		}
		[TestMethod]
		public void MultiplyFloatTest237()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(237, 237);
			Assert.AreEqual(56169, result);
		}
		[TestMethod]
		public void MultiplyFloatTest238()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(238, 238);
			Assert.AreEqual(56644, result);
		}
		[TestMethod]
		public void MultiplyFloatTest239()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(239, 239);
			Assert.AreEqual(57121, result);
		}
		[TestMethod]
		public void MultiplyFloatTest240()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(240, 240);
			Assert.AreEqual(57600, result);
		}
		[TestMethod]
		public void MultiplyFloatTest241()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(241, 241);
			Assert.AreEqual(58081, result);
		}
		[TestMethod]
		public void MultiplyFloatTest242()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(242, 242);
			Assert.AreEqual(58564, result);
		}
		[TestMethod]
		public void MultiplyFloatTest243()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(243, 243);
			Assert.AreEqual(59049, result);
		}
		[TestMethod]
		public void MultiplyFloatTest244()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(244, 244);
			Assert.AreEqual(59536, result);
		}
		[TestMethod]
		public void MultiplyFloatTest245()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(245, 245);
			Assert.AreEqual(60025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest246()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(246, 246);
			Assert.AreEqual(60516, result);
		}
		[TestMethod]
		public void MultiplyFloatTest247()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(247, 247);
			Assert.AreEqual(61009, result);
		}
		[TestMethod]
		public void MultiplyFloatTest248()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(248, 248);
			Assert.AreEqual(61504, result);
		}
		[TestMethod]
		public void MultiplyFloatTest249()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(249, 249);
			Assert.AreEqual(62001, result);
		}
		[TestMethod]
		public void MultiplyFloatTest250()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(250, 250);
			Assert.AreEqual(62500, result);
		}
		[TestMethod]
		public void MultiplyFloatTest251()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(251, 251);
			Assert.AreEqual(63001, result);
		}
		[TestMethod]
		public void MultiplyFloatTest252()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(252, 252);
			Assert.AreEqual(63504, result);
		}
		[TestMethod]
		public void MultiplyFloatTest253()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(253, 253);
			Assert.AreEqual(64009, result);
		}
		[TestMethod]
		public void MultiplyFloatTest254()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(254, 254);
			Assert.AreEqual(64516, result);
		}
		[TestMethod]
		public void MultiplyFloatTest255()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(255, 255);
			Assert.AreEqual(65025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest256()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(256, 256);
			Assert.AreEqual(65536, result);
		}
		[TestMethod]
		public void MultiplyFloatTest257()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(257, 257);
			Assert.AreEqual(66049, result);
		}
		[TestMethod]
		public void MultiplyFloatTest258()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(258, 258);
			Assert.AreEqual(66564, result);
		}
		[TestMethod]
		public void MultiplyFloatTest259()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(259, 259);
			Assert.AreEqual(67081, result);
		}
		[TestMethod]
		public void MultiplyFloatTest260()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(260, 260);
			Assert.AreEqual(67600, result);
		}
		[TestMethod]
		public void MultiplyFloatTest261()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(261, 261);
			Assert.AreEqual(68121, result);
		}
		[TestMethod]
		public void MultiplyFloatTest262()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(262, 262);
			Assert.AreEqual(68644, result);
		}
		[TestMethod]
		public void MultiplyFloatTest263()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(263, 263);
			Assert.AreEqual(69169, result);
		}
		[TestMethod]
		public void MultiplyFloatTest264()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(264, 264);
			Assert.AreEqual(69696, result);
		}
		[TestMethod]
		public void MultiplyFloatTest265()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(265, 265);
			Assert.AreEqual(70225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest266()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(266, 266);
			Assert.AreEqual(70756, result);
		}
		[TestMethod]
		public void MultiplyFloatTest267()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(267, 267);
			Assert.AreEqual(71289, result);
		}
		[TestMethod]
		public void MultiplyFloatTest268()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(268, 268);
			Assert.AreEqual(71824, result);
		}
		[TestMethod]
		public void MultiplyFloatTest269()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(269, 269);
			Assert.AreEqual(72361, result);
		}
		[TestMethod]
		public void MultiplyFloatTest270()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(270, 270);
			Assert.AreEqual(72900, result);
		}
		[TestMethod]
		public void MultiplyFloatTest271()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(271, 271);
			Assert.AreEqual(73441, result);
		}
		[TestMethod]
		public void MultiplyFloatTest272()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(272, 272);
			Assert.AreEqual(73984, result);
		}
		[TestMethod]
		public void MultiplyFloatTest273()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(273, 273);
			Assert.AreEqual(74529, result);
		}
		[TestMethod]
		public void MultiplyFloatTest274()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(274, 274);
			Assert.AreEqual(75076, result);
		}
		[TestMethod]
		public void MultiplyFloatTest275()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(275, 275);
			Assert.AreEqual(75625, result);
		}
		[TestMethod]
		public void MultiplyFloatTest276()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(276, 276);
			Assert.AreEqual(76176, result);
		}
		[TestMethod]
		public void MultiplyFloatTest277()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(277, 277);
			Assert.AreEqual(76729, result);
		}
		[TestMethod]
		public void MultiplyFloatTest278()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(278, 278);
			Assert.AreEqual(77284, result);
		}
		[TestMethod]
		public void MultiplyFloatTest279()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(279, 279);
			Assert.AreEqual(77841, result);
		}
		[TestMethod]
		public void MultiplyFloatTest280()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(280, 280);
			Assert.AreEqual(78400, result);
		}
		[TestMethod]
		public void MultiplyFloatTest281()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(281, 281);
			Assert.AreEqual(78961, result);
		}
		[TestMethod]
		public void MultiplyFloatTest282()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(282, 282);
			Assert.AreEqual(79524, result);
		}
		[TestMethod]
		public void MultiplyFloatTest283()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(283, 283);
			Assert.AreEqual(80089, result);
		}
		[TestMethod]
		public void MultiplyFloatTest284()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(284, 284);
			Assert.AreEqual(80656, result);
		}
		[TestMethod]
		public void MultiplyFloatTest285()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(285, 285);
			Assert.AreEqual(81225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest286()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(286, 286);
			Assert.AreEqual(81796, result);
		}
		[TestMethod]
		public void MultiplyFloatTest287()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(287, 287);
			Assert.AreEqual(82369, result);
		}
		[TestMethod]
		public void MultiplyFloatTest288()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(288, 288);
			Assert.AreEqual(82944, result);
		}
		[TestMethod]
		public void MultiplyFloatTest289()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(289, 289);
			Assert.AreEqual(83521, result);
		}
		[TestMethod]
		public void MultiplyFloatTest290()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(290, 290);
			Assert.AreEqual(84100, result);
		}
		[TestMethod]
		public void MultiplyFloatTest291()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(291, 291);
			Assert.AreEqual(84681, result);
		}
		[TestMethod]
		public void MultiplyFloatTest292()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(292, 292);
			Assert.AreEqual(85264, result);
		}
		[TestMethod]
		public void MultiplyFloatTest293()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(293, 293);
			Assert.AreEqual(85849, result);
		}
		[TestMethod]
		public void MultiplyFloatTest294()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(294, 294);
			Assert.AreEqual(86436, result);
		}
		[TestMethod]
		public void MultiplyFloatTest295()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(295, 295);
			Assert.AreEqual(87025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest296()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(296, 296);
			Assert.AreEqual(87616, result);
		}
		[TestMethod]
		public void MultiplyFloatTest297()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(297, 297);
			Assert.AreEqual(88209, result);
		}
		[TestMethod]
		public void MultiplyFloatTest298()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(298, 298);
			Assert.AreEqual(88804, result);
		}
		[TestMethod]
		public void MultiplyFloatTest299()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(299, 299);
			Assert.AreEqual(89401, result);
		}
		[TestMethod]
		public void MultiplyFloatTest300()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(300, 300);
			Assert.AreEqual(90000, result);
		}
		[TestMethod]
		public void MultiplyFloatTest301()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(301, 301);
			Assert.AreEqual(90601, result);
		}
		[TestMethod]
		public void MultiplyFloatTest302()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(302, 302);
			Assert.AreEqual(91204, result);
		}
		[TestMethod]
		public void MultiplyFloatTest303()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(303, 303);
			Assert.AreEqual(91809, result);
		}
		[TestMethod]
		public void MultiplyFloatTest304()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(304, 304);
			Assert.AreEqual(92416, result);
		}
		[TestMethod]
		public void MultiplyFloatTest305()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(305, 305);
			Assert.AreEqual(93025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest306()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(306, 306);
			Assert.AreEqual(93636, result);
		}
		[TestMethod]
		public void MultiplyFloatTest307()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(307, 307);
			Assert.AreEqual(94249, result);
		}
		[TestMethod]
		public void MultiplyFloatTest308()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(308, 308);
			Assert.AreEqual(94864, result);
		}
		[TestMethod]
		public void MultiplyFloatTest309()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(309, 309);
			Assert.AreEqual(95481, result);
		}
		[TestMethod]
		public void MultiplyFloatTest310()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(310, 310);
			Assert.AreEqual(96100, result);
		}
		[TestMethod]
		public void MultiplyFloatTest311()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(311, 311);
			Assert.AreEqual(96721, result);
		}
		[TestMethod]
		public void MultiplyFloatTest312()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(312, 312);
			Assert.AreEqual(97344, result);
		}
		[TestMethod]
		public void MultiplyFloatTest313()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(313, 313);
			Assert.AreEqual(97969, result);
		}
		[TestMethod]
		public void MultiplyFloatTest314()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(314, 314);
			Assert.AreEqual(98596, result);
		}
		[TestMethod]
		public void MultiplyFloatTest315()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(315, 315);
			Assert.AreEqual(99225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest316()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(316, 316);
			Assert.AreEqual(99856, result);
		}
		[TestMethod]
		public void MultiplyFloatTest317()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(317, 317);
			Assert.AreEqual(100489, result);
		}
		[TestMethod]
		public void MultiplyFloatTest318()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(318, 318);
			Assert.AreEqual(101124, result);
		}
		[TestMethod]
		public void MultiplyFloatTest319()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(319, 319);
			Assert.AreEqual(101761, result);
		}
		[TestMethod]
		public void MultiplyFloatTest320()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(320, 320);
			Assert.AreEqual(102400, result);
		}
		[TestMethod]
		public void MultiplyFloatTest321()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(321, 321);
			Assert.AreEqual(103041, result);
		}
		[TestMethod]
		public void MultiplyFloatTest322()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(322, 322);
			Assert.AreEqual(103684, result);
		}
		[TestMethod]
		public void MultiplyFloatTest323()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(323, 323);
			Assert.AreEqual(104329, result);
		}
		[TestMethod]
		public void MultiplyFloatTest324()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(324, 324);
			Assert.AreEqual(104976, result);
		}
		[TestMethod]
		public void MultiplyFloatTest325()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(325, 325);
			Assert.AreEqual(105625, result);
		}
		[TestMethod]
		public void MultiplyFloatTest326()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(326, 326);
			Assert.AreEqual(106276, result);
		}
		[TestMethod]
		public void MultiplyFloatTest327()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(327, 327);
			Assert.AreEqual(106929, result);
		}
		[TestMethod]
		public void MultiplyFloatTest328()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(328, 328);
			Assert.AreEqual(107584, result);
		}
		[TestMethod]
		public void MultiplyFloatTest329()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(329, 329);
			Assert.AreEqual(108241, result);
		}
		[TestMethod]
		public void MultiplyFloatTest330()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(330, 330);
			Assert.AreEqual(108900, result);
		}
		[TestMethod]
		public void MultiplyFloatTest331()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(331, 331);
			Assert.AreEqual(109561, result);
		}
		[TestMethod]
		public void MultiplyFloatTest332()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(332, 332);
			Assert.AreEqual(110224, result);
		}
		[TestMethod]
		public void MultiplyFloatTest333()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(333, 333);
			Assert.AreEqual(110889, result);
		}
		[TestMethod]
		public void MultiplyFloatTest334()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(334, 334);
			Assert.AreEqual(111556, result);
		}
		[TestMethod]
		public void MultiplyFloatTest335()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(335, 335);
			Assert.AreEqual(112225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest336()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(336, 336);
			Assert.AreEqual(112896, result);
		}
		[TestMethod]
		public void MultiplyFloatTest337()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(337, 337);
			Assert.AreEqual(113569, result);
		}
		[TestMethod]
		public void MultiplyFloatTest338()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(338, 338);
			Assert.AreEqual(114244, result);
		}
		[TestMethod]
		public void MultiplyFloatTest339()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(339, 339);
			Assert.AreEqual(114921, result);
		}
		[TestMethod]
		public void MultiplyFloatTest340()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(340, 340);
			Assert.AreEqual(115600, result);
		}
		[TestMethod]
		public void MultiplyFloatTest341()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(341, 341);
			Assert.AreEqual(116281, result);
		}
		[TestMethod]
		public void MultiplyFloatTest342()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(342, 342);
			Assert.AreEqual(116964, result);
		}
		[TestMethod]
		public void MultiplyFloatTest343()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(343, 343);
			Assert.AreEqual(117649, result);
		}
		[TestMethod]
		public void MultiplyFloatTest344()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(344, 344);
			Assert.AreEqual(118336, result);
		}
		[TestMethod]
		public void MultiplyFloatTest345()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(345, 345);
			Assert.AreEqual(119025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest346()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(346, 346);
			Assert.AreEqual(119716, result);
		}
		[TestMethod]
		public void MultiplyFloatTest347()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(347, 347);
			Assert.AreEqual(120409, result);
		}
		[TestMethod]
		public void MultiplyFloatTest348()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(348, 348);
			Assert.AreEqual(121104, result);
		}
		[TestMethod]
		public void MultiplyFloatTest349()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(349, 349);
			Assert.AreEqual(121801, result);
		}
		[TestMethod]
		public void MultiplyFloatTest350()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(350, 350);
			Assert.AreEqual(122500, result);
		}
		[TestMethod]
		public void MultiplyFloatTest351()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(351, 351);
			Assert.AreEqual(123201, result);
		}
		[TestMethod]
		public void MultiplyFloatTest352()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(352, 352);
			Assert.AreEqual(123904, result);
		}
		[TestMethod]
		public void MultiplyFloatTest353()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(353, 353);
			Assert.AreEqual(124609, result);
		}
		[TestMethod]
		public void MultiplyFloatTest354()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(354, 354);
			Assert.AreEqual(125316, result);
		}
		[TestMethod]
		public void MultiplyFloatTest355()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(355, 355);
			Assert.AreEqual(126025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest356()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(356, 356);
			Assert.AreEqual(126736, result);
		}
		[TestMethod]
		public void MultiplyFloatTest357()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(357, 357);
			Assert.AreEqual(127449, result);
		}
		[TestMethod]
		public void MultiplyFloatTest358()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(358, 358);
			Assert.AreEqual(128164, result);
		}
		[TestMethod]
		public void MultiplyFloatTest359()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(359, 359);
			Assert.AreEqual(128881, result);
		}
		[TestMethod]
		public void MultiplyFloatTest360()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(360, 360);
			Assert.AreEqual(129600, result);
		}
		[TestMethod]
		public void MultiplyFloatTest361()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(361, 361);
			Assert.AreEqual(130321, result);
		}
		[TestMethod]
		public void MultiplyFloatTest362()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(362, 362);
			Assert.AreEqual(131044, result);
		}
		[TestMethod]
		public void MultiplyFloatTest363()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(363, 363);
			Assert.AreEqual(131769, result);
		}
		[TestMethod]
		public void MultiplyFloatTest364()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(364, 364);
			Assert.AreEqual(132496, result);
		}
		[TestMethod]
		public void MultiplyFloatTest365()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(365, 365);
			Assert.AreEqual(133225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest366()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(366, 366);
			Assert.AreEqual(133956, result);
		}
		[TestMethod]
		public void MultiplyFloatTest367()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(367, 367);
			Assert.AreEqual(134689, result);
		}
		[TestMethod]
		public void MultiplyFloatTest368()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(368, 368);
			Assert.AreEqual(135424, result);
		}
		[TestMethod]
		public void MultiplyFloatTest369()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(369, 369);
			Assert.AreEqual(136161, result);
		}
		[TestMethod]
		public void MultiplyFloatTest370()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(370, 370);
			Assert.AreEqual(136900, result);
		}
		[TestMethod]
		public void MultiplyFloatTest371()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(371, 371);
			Assert.AreEqual(137641, result);
		}
		[TestMethod]
		public void MultiplyFloatTest372()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(372, 372);
			Assert.AreEqual(138384, result);
		}
		[TestMethod]
		public void MultiplyFloatTest373()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(373, 373);
			Assert.AreEqual(139129, result);
		}
		[TestMethod]
		public void MultiplyFloatTest374()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(374, 374);
			Assert.AreEqual(139876, result);
		}
		[TestMethod]
		public void MultiplyFloatTest375()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(375, 375);
			Assert.AreEqual(140625, result);
		}
		[TestMethod]
		public void MultiplyFloatTest376()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(376, 376);
			Assert.AreEqual(141376, result);
		}
		[TestMethod]
		public void MultiplyFloatTest377()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(377, 377);
			Assert.AreEqual(142129, result);
		}
		[TestMethod]
		public void MultiplyFloatTest378()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(378, 378);
			Assert.AreEqual(142884, result);
		}
		[TestMethod]
		public void MultiplyFloatTest379()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(379, 379);
			Assert.AreEqual(143641, result);
		}
		[TestMethod]
		public void MultiplyFloatTest380()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(380, 380);
			Assert.AreEqual(144400, result);
		}
		[TestMethod]
		public void MultiplyFloatTest381()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(381, 381);
			Assert.AreEqual(145161, result);
		}
		[TestMethod]
		public void MultiplyFloatTest382()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(382, 382);
			Assert.AreEqual(145924, result);
		}
		[TestMethod]
		public void MultiplyFloatTest383()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(383, 383);
			Assert.AreEqual(146689, result);
		}
		[TestMethod]
		public void MultiplyFloatTest384()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(384, 384);
			Assert.AreEqual(147456, result);
		}
		[TestMethod]
		public void MultiplyFloatTest385()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(385, 385);
			Assert.AreEqual(148225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest386()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(386, 386);
			Assert.AreEqual(148996, result);
		}
		[TestMethod]
		public void MultiplyFloatTest387()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(387, 387);
			Assert.AreEqual(149769, result);
		}
		[TestMethod]
		public void MultiplyFloatTest388()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(388, 388);
			Assert.AreEqual(150544, result);
		}
		[TestMethod]
		public void MultiplyFloatTest389()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(389, 389);
			Assert.AreEqual(151321, result);
		}
		[TestMethod]
		public void MultiplyFloatTest390()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(390, 390);
			Assert.AreEqual(152100, result);
		}
		[TestMethod]
		public void MultiplyFloatTest391()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(391, 391);
			Assert.AreEqual(152881, result);
		}
		[TestMethod]
		public void MultiplyFloatTest392()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(392, 392);
			Assert.AreEqual(153664, result);
		}
		[TestMethod]
		public void MultiplyFloatTest393()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(393, 393);
			Assert.AreEqual(154449, result);
		}
		[TestMethod]
		public void MultiplyFloatTest394()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(394, 394);
			Assert.AreEqual(155236, result);
		}
		[TestMethod]
		public void MultiplyFloatTest395()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(395, 395);
			Assert.AreEqual(156025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest396()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(396, 396);
			Assert.AreEqual(156816, result);
		}
		[TestMethod]
		public void MultiplyFloatTest397()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(397, 397);
			Assert.AreEqual(157609, result);
		}
		[TestMethod]
		public void MultiplyFloatTest398()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(398, 398);
			Assert.AreEqual(158404, result);
		}
		[TestMethod]
		public void MultiplyFloatTest399()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(399, 399);
			Assert.AreEqual(159201, result);
		}
		[TestMethod]
		public void MultiplyFloatTest400()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(400, 400);
			Assert.AreEqual(160000, result);
		}
		[TestMethod]
		public void MultiplyFloatTest401()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(401, 401);
			Assert.AreEqual(160801, result);
		}
		[TestMethod]
		public void MultiplyFloatTest402()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(402, 402);
			Assert.AreEqual(161604, result);
		}
		[TestMethod]
		public void MultiplyFloatTest403()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(403, 403);
			Assert.AreEqual(162409, result);
		}
		[TestMethod]
		public void MultiplyFloatTest404()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(404, 404);
			Assert.AreEqual(163216, result);
		}
		[TestMethod]
		public void MultiplyFloatTest405()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(405, 405);
			Assert.AreEqual(164025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest406()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(406, 406);
			Assert.AreEqual(164836, result);
		}
		[TestMethod]
		public void MultiplyFloatTest407()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(407, 407);
			Assert.AreEqual(165649, result);
		}
		[TestMethod]
		public void MultiplyFloatTest408()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(408, 408);
			Assert.AreEqual(166464, result);
		}
		[TestMethod]
		public void MultiplyFloatTest409()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(409, 409);
			Assert.AreEqual(167281, result);
		}
		[TestMethod]
		public void MultiplyFloatTest410()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(410, 410);
			Assert.AreEqual(168100, result);
		}
		[TestMethod]
		public void MultiplyFloatTest411()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(411, 411);
			Assert.AreEqual(168921, result);
		}
		[TestMethod]
		public void MultiplyFloatTest412()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(412, 412);
			Assert.AreEqual(169744, result);
		}
		[TestMethod]
		public void MultiplyFloatTest413()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(413, 413);
			Assert.AreEqual(170569, result);
		}
		[TestMethod]
		public void MultiplyFloatTest414()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(414, 414);
			Assert.AreEqual(171396, result);
		}
		[TestMethod]
		public void MultiplyFloatTest415()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(415, 415);
			Assert.AreEqual(172225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest416()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(416, 416);
			Assert.AreEqual(173056, result);
		}
		[TestMethod]
		public void MultiplyFloatTest417()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(417, 417);
			Assert.AreEqual(173889, result);
		}
		[TestMethod]
		public void MultiplyFloatTest418()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(418, 418);
			Assert.AreEqual(174724, result);
		}
		[TestMethod]
		public void MultiplyFloatTest419()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(419, 419);
			Assert.AreEqual(175561, result);
		}
		[TestMethod]
		public void MultiplyFloatTest420()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(420, 420);
			Assert.AreEqual(176400, result);
		}
		[TestMethod]
		public void MultiplyFloatTest421()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(421, 421);
			Assert.AreEqual(177241, result);
		}
		[TestMethod]
		public void MultiplyFloatTest422()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(422, 422);
			Assert.AreEqual(178084, result);
		}
		[TestMethod]
		public void MultiplyFloatTest423()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(423, 423);
			Assert.AreEqual(178929, result);
		}
		[TestMethod]
		public void MultiplyFloatTest424()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(424, 424);
			Assert.AreEqual(179776, result);
		}
		[TestMethod]
		public void MultiplyFloatTest425()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(425, 425);
			Assert.AreEqual(180625, result);
		}
		[TestMethod]
		public void MultiplyFloatTest426()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(426, 426);
			Assert.AreEqual(181476, result);
		}
		[TestMethod]
		public void MultiplyFloatTest427()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(427, 427);
			Assert.AreEqual(182329, result);
		}
		[TestMethod]
		public void MultiplyFloatTest428()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(428, 428);
			Assert.AreEqual(183184, result);
		}
		[TestMethod]
		public void MultiplyFloatTest429()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(429, 429);
			Assert.AreEqual(184041, result);
		}
		[TestMethod]
		public void MultiplyFloatTest430()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(430, 430);
			Assert.AreEqual(184900, result);
		}
		[TestMethod]
		public void MultiplyFloatTest431()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(431, 431);
			Assert.AreEqual(185761, result);
		}
		[TestMethod]
		public void MultiplyFloatTest432()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(432, 432);
			Assert.AreEqual(186624, result);
		}
		[TestMethod]
		public void MultiplyFloatTest433()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(433, 433);
			Assert.AreEqual(187489, result);
		}
		[TestMethod]
		public void MultiplyFloatTest434()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(434, 434);
			Assert.AreEqual(188356, result);
		}
		[TestMethod]
		public void MultiplyFloatTest435()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(435, 435);
			Assert.AreEqual(189225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest436()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(436, 436);
			Assert.AreEqual(190096, result);
		}
		[TestMethod]
		public void MultiplyFloatTest437()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(437, 437);
			Assert.AreEqual(190969, result);
		}
		[TestMethod]
		public void MultiplyFloatTest438()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(438, 438);
			Assert.AreEqual(191844, result);
		}
		[TestMethod]
		public void MultiplyFloatTest439()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(439, 439);
			Assert.AreEqual(192721, result);
		}
		[TestMethod]
		public void MultiplyFloatTest440()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(440, 440);
			Assert.AreEqual(193600, result);
		}
		[TestMethod]
		public void MultiplyFloatTest441()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(441, 441);
			Assert.AreEqual(194481, result);
		}
		[TestMethod]
		public void MultiplyFloatTest442()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(442, 442);
			Assert.AreEqual(195364, result);
		}
		[TestMethod]
		public void MultiplyFloatTest443()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(443, 443);
			Assert.AreEqual(196249, result);
		}
		[TestMethod]
		public void MultiplyFloatTest444()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(444, 444);
			Assert.AreEqual(197136, result);
		}
		[TestMethod]
		public void MultiplyFloatTest445()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(445, 445);
			Assert.AreEqual(198025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest446()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(446, 446);
			Assert.AreEqual(198916, result);
		}
		[TestMethod]
		public void MultiplyFloatTest447()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(447, 447);
			Assert.AreEqual(199809, result);
		}
		[TestMethod]
		public void MultiplyFloatTest448()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(448, 448);
			Assert.AreEqual(200704, result);
		}
		[TestMethod]
		public void MultiplyFloatTest449()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(449, 449);
			Assert.AreEqual(201601, result);
		}
		[TestMethod]
		public void MultiplyFloatTest450()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(450, 450);
			Assert.AreEqual(202500, result);
		}
		[TestMethod]
		public void MultiplyFloatTest451()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(451, 451);
			Assert.AreEqual(203401, result);
		}
		[TestMethod]
		public void MultiplyFloatTest452()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(452, 452);
			Assert.AreEqual(204304, result);
		}
		[TestMethod]
		public void MultiplyFloatTest453()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(453, 453);
			Assert.AreEqual(205209, result);
		}
		[TestMethod]
		public void MultiplyFloatTest454()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(454, 454);
			Assert.AreEqual(206116, result);
		}
		[TestMethod]
		public void MultiplyFloatTest455()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(455, 455);
			Assert.AreEqual(207025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest456()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(456, 456);
			Assert.AreEqual(207936, result);
		}
		[TestMethod]
		public void MultiplyFloatTest457()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(457, 457);
			Assert.AreEqual(208849, result);
		}
		[TestMethod]
		public void MultiplyFloatTest458()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(458, 458);
			Assert.AreEqual(209764, result);
		}
		[TestMethod]
		public void MultiplyFloatTest459()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(459, 459);
			Assert.AreEqual(210681, result);
		}
		[TestMethod]
		public void MultiplyFloatTest460()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(460, 460);
			Assert.AreEqual(211600, result);
		}
		[TestMethod]
		public void MultiplyFloatTest461()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(461, 461);
			Assert.AreEqual(212521, result);
		}
		[TestMethod]
		public void MultiplyFloatTest462()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(462, 462);
			Assert.AreEqual(213444, result);
		}
		[TestMethod]
		public void MultiplyFloatTest463()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(463, 463);
			Assert.AreEqual(214369, result);
		}
		[TestMethod]
		public void MultiplyFloatTest464()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(464, 464);
			Assert.AreEqual(215296, result);
		}
		[TestMethod]
		public void MultiplyFloatTest465()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(465, 465);
			Assert.AreEqual(216225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest466()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(466, 466);
			Assert.AreEqual(217156, result);
		}
		[TestMethod]
		public void MultiplyFloatTest467()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(467, 467);
			Assert.AreEqual(218089, result);
		}
		[TestMethod]
		public void MultiplyFloatTest468()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(468, 468);
			Assert.AreEqual(219024, result);
		}
		[TestMethod]
		public void MultiplyFloatTest469()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(469, 469);
			Assert.AreEqual(219961, result);
		}
		[TestMethod]
		public void MultiplyFloatTest470()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(470, 470);
			Assert.AreEqual(220900, result);
		}
		[TestMethod]
		public void MultiplyFloatTest471()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(471, 471);
			Assert.AreEqual(221841, result);
		}
		[TestMethod]
		public void MultiplyFloatTest472()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(472, 472);
			Assert.AreEqual(222784, result);
		}
		[TestMethod]
		public void MultiplyFloatTest473()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(473, 473);
			Assert.AreEqual(223729, result);
		}
		[TestMethod]
		public void MultiplyFloatTest474()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(474, 474);
			Assert.AreEqual(224676, result);
		}
		[TestMethod]
		public void MultiplyFloatTest475()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(475, 475);
			Assert.AreEqual(225625, result);
		}
		[TestMethod]
		public void MultiplyFloatTest476()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(476, 476);
			Assert.AreEqual(226576, result);
		}
		[TestMethod]
		public void MultiplyFloatTest477()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(477, 477);
			Assert.AreEqual(227529, result);
		}
		[TestMethod]
		public void MultiplyFloatTest478()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(478, 478);
			Assert.AreEqual(228484, result);
		}
		[TestMethod]
		public void MultiplyFloatTest479()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(479, 479);
			Assert.AreEqual(229441, result);
		}
		[TestMethod]
		public void MultiplyFloatTest480()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(480, 480);
			Assert.AreEqual(230400, result);
		}
		[TestMethod]
		public void MultiplyFloatTest481()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(481, 481);
			Assert.AreEqual(231361, result);
		}
		[TestMethod]
		public void MultiplyFloatTest482()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(482, 482);
			Assert.AreEqual(232324, result);
		}
		[TestMethod]
		public void MultiplyFloatTest483()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(483, 483);
			Assert.AreEqual(233289, result);
		}
		[TestMethod]
		public void MultiplyFloatTest484()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(484, 484);
			Assert.AreEqual(234256, result);
		}
		[TestMethod]
		public void MultiplyFloatTest485()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(485, 485);
			Assert.AreEqual(235225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest486()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(486, 486);
			Assert.AreEqual(236196, result);
		}
		[TestMethod]
		public void MultiplyFloatTest487()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(487, 487);
			Assert.AreEqual(237169, result);
		}
		[TestMethod]
		public void MultiplyFloatTest488()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(488, 488);
			Assert.AreEqual(238144, result);
		}
		[TestMethod]
		public void MultiplyFloatTest489()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(489, 489);
			Assert.AreEqual(239121, result);
		}
		[TestMethod]
		public void MultiplyFloatTest490()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(490, 490);
			Assert.AreEqual(240100, result);
		}
		[TestMethod]
		public void MultiplyFloatTest491()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(491, 491);
			Assert.AreEqual(241081, result);
		}
		[TestMethod]
		public void MultiplyFloatTest492()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(492, 492);
			Assert.AreEqual(242064, result);
		}
		[TestMethod]
		public void MultiplyFloatTest493()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(493, 493);
			Assert.AreEqual(243049, result);
		}
		[TestMethod]
		public void MultiplyFloatTest494()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(494, 494);
			Assert.AreEqual(244036, result);
		}
		[TestMethod]
		public void MultiplyFloatTest495()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(495, 495);
			Assert.AreEqual(245025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest496()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(496, 496);
			Assert.AreEqual(246016, result);
		}
		[TestMethod]
		public void MultiplyFloatTest497()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(497, 497);
			Assert.AreEqual(247009, result);
		}
		[TestMethod]
		public void MultiplyFloatTest498()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(498, 498);
			Assert.AreEqual(248004, result);
		}
		[TestMethod]
		public void MultiplyFloatTest499()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(499, 499);
			Assert.AreEqual(249001, result);
		}
		[TestMethod]
		public void MultiplyFloatTest500()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(500, 500);
			Assert.AreEqual(250000, result);
		}
		[TestMethod]
		public void MultiplyFloatTest501()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(501, 501);
			Assert.AreEqual(251001, result);
		}
		[TestMethod]
		public void MultiplyFloatTest502()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(502, 502);
			Assert.AreEqual(252004, result);
		}
		[TestMethod]
		public void MultiplyFloatTest503()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(503, 503);
			Assert.AreEqual(253009, result);
		}
		[TestMethod]
		public void MultiplyFloatTest504()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(504, 504);
			Assert.AreEqual(254016, result);
		}
		[TestMethod]
		public void MultiplyFloatTest505()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(505, 505);
			Assert.AreEqual(255025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest506()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(506, 506);
			Assert.AreEqual(256036, result);
		}
		[TestMethod]
		public void MultiplyFloatTest507()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(507, 507);
			Assert.AreEqual(257049, result);
		}
		[TestMethod]
		public void MultiplyFloatTest508()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(508, 508);
			Assert.AreEqual(258064, result);
		}
		[TestMethod]
		public void MultiplyFloatTest509()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(509, 509);
			Assert.AreEqual(259081, result);
		}
		[TestMethod]
		public void MultiplyFloatTest510()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(510, 510);
			Assert.AreEqual(260100, result);
		}
		[TestMethod]
		public void MultiplyFloatTest511()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(511, 511);
			Assert.AreEqual(261121, result);
		}
		[TestMethod]
		public void MultiplyFloatTest512()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(512, 512);
			Assert.AreEqual(262144, result);
		}
		[TestMethod]
		public void MultiplyFloatTest513()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(513, 513);
			Assert.AreEqual(263169, result);
		}
		[TestMethod]
		public void MultiplyFloatTest514()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(514, 514);
			Assert.AreEqual(264196, result);
		}
		[TestMethod]
		public void MultiplyFloatTest515()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(515, 515);
			Assert.AreEqual(265225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest516()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(516, 516);
			Assert.AreEqual(266256, result);
		}
		[TestMethod]
		public void MultiplyFloatTest517()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(517, 517);
			Assert.AreEqual(267289, result);
		}
		[TestMethod]
		public void MultiplyFloatTest518()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(518, 518);
			Assert.AreEqual(268324, result);
		}
		[TestMethod]
		public void MultiplyFloatTest519()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(519, 519);
			Assert.AreEqual(269361, result);
		}
		[TestMethod]
		public void MultiplyFloatTest520()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(520, 520);
			Assert.AreEqual(270400, result);
		}
		[TestMethod]
		public void MultiplyFloatTest521()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(521, 521);
			Assert.AreEqual(271441, result);
		}
		[TestMethod]
		public void MultiplyFloatTest522()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(522, 522);
			Assert.AreEqual(272484, result);
		}
		[TestMethod]
		public void MultiplyFloatTest523()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(523, 523);
			Assert.AreEqual(273529, result);
		}
		[TestMethod]
		public void MultiplyFloatTest524()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(524, 524);
			Assert.AreEqual(274576, result);
		}
		[TestMethod]
		public void MultiplyFloatTest525()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(525, 525);
			Assert.AreEqual(275625, result);
		}
		[TestMethod]
		public void MultiplyFloatTest526()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(526, 526);
			Assert.AreEqual(276676, result);
		}
		[TestMethod]
		public void MultiplyFloatTest527()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(527, 527);
			Assert.AreEqual(277729, result);
		}
		[TestMethod]
		public void MultiplyFloatTest528()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(528, 528);
			Assert.AreEqual(278784, result);
		}
		[TestMethod]
		public void MultiplyFloatTest529()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(529, 529);
			Assert.AreEqual(279841, result);
		}
		[TestMethod]
		public void MultiplyFloatTest530()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(530, 530);
			Assert.AreEqual(280900, result);
		}
		[TestMethod]
		public void MultiplyFloatTest531()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(531, 531);
			Assert.AreEqual(281961, result);
		}
		[TestMethod]
		public void MultiplyFloatTest532()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(532, 532);
			Assert.AreEqual(283024, result);
		}
		[TestMethod]
		public void MultiplyFloatTest533()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(533, 533);
			Assert.AreEqual(284089, result);
		}
		[TestMethod]
		public void MultiplyFloatTest534()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(534, 534);
			Assert.AreEqual(285156, result);
		}
		[TestMethod]
		public void MultiplyFloatTest535()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(535, 535);
			Assert.AreEqual(286225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest536()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(536, 536);
			Assert.AreEqual(287296, result);
		}
		[TestMethod]
		public void MultiplyFloatTest537()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(537, 537);
			Assert.AreEqual(288369, result);
		}
		[TestMethod]
		public void MultiplyFloatTest538()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(538, 538);
			Assert.AreEqual(289444, result);
		}
		[TestMethod]
		public void MultiplyFloatTest539()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(539, 539);
			Assert.AreEqual(290521, result);
		}
		[TestMethod]
		public void MultiplyFloatTest540()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(540, 540);
			Assert.AreEqual(291600, result);
		}
		[TestMethod]
		public void MultiplyFloatTest541()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(541, 541);
			Assert.AreEqual(292681, result);
		}
		[TestMethod]
		public void MultiplyFloatTest542()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(542, 542);
			Assert.AreEqual(293764, result);
		}
		[TestMethod]
		public void MultiplyFloatTest543()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(543, 543);
			Assert.AreEqual(294849, result);
		}
		[TestMethod]
		public void MultiplyFloatTest544()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(544, 544);
			Assert.AreEqual(295936, result);
		}
		[TestMethod]
		public void MultiplyFloatTest545()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(545, 545);
			Assert.AreEqual(297025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest546()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(546, 546);
			Assert.AreEqual(298116, result);
		}
		[TestMethod]
		public void MultiplyFloatTest547()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(547, 547);
			Assert.AreEqual(299209, result);
		}
		[TestMethod]
		public void MultiplyFloatTest548()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(548, 548);
			Assert.AreEqual(300304, result);
		}
		[TestMethod]
		public void MultiplyFloatTest549()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(549, 549);
			Assert.AreEqual(301401, result);
		}
		[TestMethod]
		public void MultiplyFloatTest550()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(550, 550);
			Assert.AreEqual(302500, result);
		}
		[TestMethod]
		public void MultiplyFloatTest551()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(551, 551);
			Assert.AreEqual(303601, result);
		}
		[TestMethod]
		public void MultiplyFloatTest552()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(552, 552);
			Assert.AreEqual(304704, result);
		}
		[TestMethod]
		public void MultiplyFloatTest553()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(553, 553);
			Assert.AreEqual(305809, result);
		}
		[TestMethod]
		public void MultiplyFloatTest554()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(554, 554);
			Assert.AreEqual(306916, result);
		}
		[TestMethod]
		public void MultiplyFloatTest555()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(555, 555);
			Assert.AreEqual(308025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest556()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(556, 556);
			Assert.AreEqual(309136, result);
		}
		[TestMethod]
		public void MultiplyFloatTest557()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(557, 557);
			Assert.AreEqual(310249, result);
		}
		[TestMethod]
		public void MultiplyFloatTest558()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(558, 558);
			Assert.AreEqual(311364, result);
		}
		[TestMethod]
		public void MultiplyFloatTest559()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(559, 559);
			Assert.AreEqual(312481, result);
		}
		[TestMethod]
		public void MultiplyFloatTest560()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(560, 560);
			Assert.AreEqual(313600, result);
		}
		[TestMethod]
		public void MultiplyFloatTest561()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(561, 561);
			Assert.AreEqual(314721, result);
		}
		[TestMethod]
		public void MultiplyFloatTest562()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(562, 562);
			Assert.AreEqual(315844, result);
		}
		[TestMethod]
		public void MultiplyFloatTest563()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(563, 563);
			Assert.AreEqual(316969, result);
		}
		[TestMethod]
		public void MultiplyFloatTest564()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(564, 564);
			Assert.AreEqual(318096, result);
		}
		[TestMethod]
		public void MultiplyFloatTest565()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(565, 565);
			Assert.AreEqual(319225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest566()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(566, 566);
			Assert.AreEqual(320356, result);
		}
		[TestMethod]
		public void MultiplyFloatTest567()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(567, 567);
			Assert.AreEqual(321489, result);
		}
		[TestMethod]
		public void MultiplyFloatTest568()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(568, 568);
			Assert.AreEqual(322624, result);
		}
		[TestMethod]
		public void MultiplyFloatTest569()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(569, 569);
			Assert.AreEqual(323761, result);
		}
		[TestMethod]
		public void MultiplyFloatTest570()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(570, 570);
			Assert.AreEqual(324900, result);
		}
		[TestMethod]
		public void MultiplyFloatTest571()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(571, 571);
			Assert.AreEqual(326041, result);
		}
		[TestMethod]
		public void MultiplyFloatTest572()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(572, 572);
			Assert.AreEqual(327184, result);
		}
		[TestMethod]
		public void MultiplyFloatTest573()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(573, 573);
			Assert.AreEqual(328329, result);
		}
		[TestMethod]
		public void MultiplyFloatTest574()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(574, 574);
			Assert.AreEqual(329476, result);
		}
		[TestMethod]
		public void MultiplyFloatTest575()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(575, 575);
			Assert.AreEqual(330625, result);
		}
		[TestMethod]
		public void MultiplyFloatTest576()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(576, 576);
			Assert.AreEqual(331776, result);
		}
		[TestMethod]
		public void MultiplyFloatTest577()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(577, 577);
			Assert.AreEqual(332929, result);
		}
		[TestMethod]
		public void MultiplyFloatTest578()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(578, 578);
			Assert.AreEqual(334084, result);
		}
		[TestMethod]
		public void MultiplyFloatTest579()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(579, 579);
			Assert.AreEqual(335241, result);
		}
		[TestMethod]
		public void MultiplyFloatTest580()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(580, 580);
			Assert.AreEqual(336400, result);
		}
		[TestMethod]
		public void MultiplyFloatTest581()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(581, 581);
			Assert.AreEqual(337561, result);
		}
		[TestMethod]
		public void MultiplyFloatTest582()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(582, 582);
			Assert.AreEqual(338724, result);
		}
		[TestMethod]
		public void MultiplyFloatTest583()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(583, 583);
			Assert.AreEqual(339889, result);
		}
		[TestMethod]
		public void MultiplyFloatTest584()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(584, 584);
			Assert.AreEqual(341056, result);
		}
		[TestMethod]
		public void MultiplyFloatTest585()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(585, 585);
			Assert.AreEqual(342225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest586()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(586, 586);
			Assert.AreEqual(343396, result);
		}
		[TestMethod]
		public void MultiplyFloatTest587()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(587, 587);
			Assert.AreEqual(344569, result);
		}
		[TestMethod]
		public void MultiplyFloatTest588()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(588, 588);
			Assert.AreEqual(345744, result);
		}
		[TestMethod]
		public void MultiplyFloatTest589()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(589, 589);
			Assert.AreEqual(346921, result);
		}
		[TestMethod]
		public void MultiplyFloatTest590()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(590, 590);
			Assert.AreEqual(348100, result);
		}
		[TestMethod]
		public void MultiplyFloatTest591()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(591, 591);
			Assert.AreEqual(349281, result);
		}
		[TestMethod]
		public void MultiplyFloatTest592()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(592, 592);
			Assert.AreEqual(350464, result);
		}
		[TestMethod]
		public void MultiplyFloatTest593()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(593, 593);
			Assert.AreEqual(351649, result);
		}
		[TestMethod]
		public void MultiplyFloatTest594()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(594, 594);
			Assert.AreEqual(352836, result);
		}
		[TestMethod]
		public void MultiplyFloatTest595()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(595, 595);
			Assert.AreEqual(354025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest596()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(596, 596);
			Assert.AreEqual(355216, result);
		}
		[TestMethod]
		public void MultiplyFloatTest597()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(597, 597);
			Assert.AreEqual(356409, result);
		}
		[TestMethod]
		public void MultiplyFloatTest598()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(598, 598);
			Assert.AreEqual(357604, result);
		}
		[TestMethod]
		public void MultiplyFloatTest599()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(599, 599);
			Assert.AreEqual(358801, result);
		}
		[TestMethod]
		public void MultiplyFloatTest600()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(600, 600);
			Assert.AreEqual(360000, result);
		}
		[TestMethod]
		public void MultiplyFloatTest601()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(601, 601);
			Assert.AreEqual(361201, result);
		}
		[TestMethod]
		public void MultiplyFloatTest602()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(602, 602);
			Assert.AreEqual(362404, result);
		}
		[TestMethod]
		public void MultiplyFloatTest603()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(603, 603);
			Assert.AreEqual(363609, result);
		}
		[TestMethod]
		public void MultiplyFloatTest604()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(604, 604);
			Assert.AreEqual(364816, result);
		}
		[TestMethod]
		public void MultiplyFloatTest605()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(605, 605);
			Assert.AreEqual(366025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest606()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(606, 606);
			Assert.AreEqual(367236, result);
		}
		[TestMethod]
		public void MultiplyFloatTest607()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(607, 607);
			Assert.AreEqual(368449, result);
		}
		[TestMethod]
		public void MultiplyFloatTest608()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(608, 608);
			Assert.AreEqual(369664, result);
		}
		[TestMethod]
		public void MultiplyFloatTest609()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(609, 609);
			Assert.AreEqual(370881, result);
		}
		[TestMethod]
		public void MultiplyFloatTest610()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(610, 610);
			Assert.AreEqual(372100, result);
		}
		[TestMethod]
		public void MultiplyFloatTest611()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(611, 611);
			Assert.AreEqual(373321, result);
		}
		[TestMethod]
		public void MultiplyFloatTest612()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(612, 612);
			Assert.AreEqual(374544, result);
		}
		[TestMethod]
		public void MultiplyFloatTest613()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(613, 613);
			Assert.AreEqual(375769, result);
		}
		[TestMethod]
		public void MultiplyFloatTest614()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(614, 614);
			Assert.AreEqual(376996, result);
		}
		[TestMethod]
		public void MultiplyFloatTest615()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(615, 615);
			Assert.AreEqual(378225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest616()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(616, 616);
			Assert.AreEqual(379456, result);
		}
		[TestMethod]
		public void MultiplyFloatTest617()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(617, 617);
			Assert.AreEqual(380689, result);
		}
		[TestMethod]
		public void MultiplyFloatTest618()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(618, 618);
			Assert.AreEqual(381924, result);
		}
		[TestMethod]
		public void MultiplyFloatTest619()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(619, 619);
			Assert.AreEqual(383161, result);
		}
		[TestMethod]
		public void MultiplyFloatTest620()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(620, 620);
			Assert.AreEqual(384400, result);
		}
		[TestMethod]
		public void MultiplyFloatTest621()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(621, 621);
			Assert.AreEqual(385641, result);
		}
		[TestMethod]
		public void MultiplyFloatTest622()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(622, 622);
			Assert.AreEqual(386884, result);
		}
		[TestMethod]
		public void MultiplyFloatTest623()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(623, 623);
			Assert.AreEqual(388129, result);
		}
		[TestMethod]
		public void MultiplyFloatTest624()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(624, 624);
			Assert.AreEqual(389376, result);
		}
		[TestMethod]
		public void MultiplyFloatTest625()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(625, 625);
			Assert.AreEqual(390625, result);
		}
		[TestMethod]
		public void MultiplyFloatTest626()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(626, 626);
			Assert.AreEqual(391876, result);
		}
		[TestMethod]
		public void MultiplyFloatTest627()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(627, 627);
			Assert.AreEqual(393129, result);
		}
		[TestMethod]
		public void MultiplyFloatTest628()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(628, 628);
			Assert.AreEqual(394384, result);
		}
		[TestMethod]
		public void MultiplyFloatTest629()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(629, 629);
			Assert.AreEqual(395641, result);
		}
		[TestMethod]
		public void MultiplyFloatTest630()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(630, 630);
			Assert.AreEqual(396900, result);
		}
		[TestMethod]
		public void MultiplyFloatTest631()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(631, 631);
			Assert.AreEqual(398161, result);
		}
		[TestMethod]
		public void MultiplyFloatTest632()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(632, 632);
			Assert.AreEqual(399424, result);
		}
		[TestMethod]
		public void MultiplyFloatTest633()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(633, 633);
			Assert.AreEqual(400689, result);
		}
		[TestMethod]
		public void MultiplyFloatTest634()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(634, 634);
			Assert.AreEqual(401956, result);
		}
		[TestMethod]
		public void MultiplyFloatTest635()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(635, 635);
			Assert.AreEqual(403225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest636()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(636, 636);
			Assert.AreEqual(404496, result);
		}
		[TestMethod]
		public void MultiplyFloatTest637()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(637, 637);
			Assert.AreEqual(405769, result);
		}
		[TestMethod]
		public void MultiplyFloatTest638()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(638, 638);
			Assert.AreEqual(407044, result);
		}
		[TestMethod]
		public void MultiplyFloatTest639()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(639, 639);
			Assert.AreEqual(408321, result);
		}
		[TestMethod]
		public void MultiplyFloatTest640()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(640, 640);
			Assert.AreEqual(409600, result);
		}
		[TestMethod]
		public void MultiplyFloatTest641()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(641, 641);
			Assert.AreEqual(410881, result);
		}
		[TestMethod]
		public void MultiplyFloatTest642()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(642, 642);
			Assert.AreEqual(412164, result);
		}
		[TestMethod]
		public void MultiplyFloatTest643()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(643, 643);
			Assert.AreEqual(413449, result);
		}
		[TestMethod]
		public void MultiplyFloatTest644()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(644, 644);
			Assert.AreEqual(414736, result);
		}
		[TestMethod]
		public void MultiplyFloatTest645()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(645, 645);
			Assert.AreEqual(416025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest646()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(646, 646);
			Assert.AreEqual(417316, result);
		}
		[TestMethod]
		public void MultiplyFloatTest647()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(647, 647);
			Assert.AreEqual(418609, result);
		}
		[TestMethod]
		public void MultiplyFloatTest648()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(648, 648);
			Assert.AreEqual(419904, result);
		}
		[TestMethod]
		public void MultiplyFloatTest649()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(649, 649);
			Assert.AreEqual(421201, result);
		}
		[TestMethod]
		public void MultiplyFloatTest650()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(650, 650);
			Assert.AreEqual(422500, result);
		}
		[TestMethod]
		public void MultiplyFloatTest651()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(651, 651);
			Assert.AreEqual(423801, result);
		}
		[TestMethod]
		public void MultiplyFloatTest652()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(652, 652);
			Assert.AreEqual(425104, result);
		}
		[TestMethod]
		public void MultiplyFloatTest653()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(653, 653);
			Assert.AreEqual(426409, result);
		}
		[TestMethod]
		public void MultiplyFloatTest654()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(654, 654);
			Assert.AreEqual(427716, result);
		}
		[TestMethod]
		public void MultiplyFloatTest655()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(655, 655);
			Assert.AreEqual(429025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest656()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(656, 656);
			Assert.AreEqual(430336, result);
		}
		[TestMethod]
		public void MultiplyFloatTest657()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(657, 657);
			Assert.AreEqual(431649, result);
		}
		[TestMethod]
		public void MultiplyFloatTest658()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(658, 658);
			Assert.AreEqual(432964, result);
		}
		[TestMethod]
		public void MultiplyFloatTest659()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(659, 659);
			Assert.AreEqual(434281, result);
		}
		[TestMethod]
		public void MultiplyFloatTest660()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(660, 660);
			Assert.AreEqual(435600, result);
		}
		[TestMethod]
		public void MultiplyFloatTest661()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(661, 661);
			Assert.AreEqual(436921, result);
		}
		[TestMethod]
		public void MultiplyFloatTest662()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(662, 662);
			Assert.AreEqual(438244, result);
		}
		[TestMethod]
		public void MultiplyFloatTest663()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(663, 663);
			Assert.AreEqual(439569, result);
		}
		[TestMethod]
		public void MultiplyFloatTest664()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(664, 664);
			Assert.AreEqual(440896, result);
		}
		[TestMethod]
		public void MultiplyFloatTest665()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(665, 665);
			Assert.AreEqual(442225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest666()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(666, 666);
			Assert.AreEqual(443556, result);
		}
		[TestMethod]
		public void MultiplyFloatTest667()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(667, 667);
			Assert.AreEqual(444889, result);
		}
		[TestMethod]
		public void MultiplyFloatTest668()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(668, 668);
			Assert.AreEqual(446224, result);
		}
		[TestMethod]
		public void MultiplyFloatTest669()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(669, 669);
			Assert.AreEqual(447561, result);
		}
		[TestMethod]
		public void MultiplyFloatTest670()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(670, 670);
			Assert.AreEqual(448900, result);
		}
		[TestMethod]
		public void MultiplyFloatTest671()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(671, 671);
			Assert.AreEqual(450241, result);
		}
		[TestMethod]
		public void MultiplyFloatTest672()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(672, 672);
			Assert.AreEqual(451584, result);
		}
		[TestMethod]
		public void MultiplyFloatTest673()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(673, 673);
			Assert.AreEqual(452929, result);
		}
		[TestMethod]
		public void MultiplyFloatTest674()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(674, 674);
			Assert.AreEqual(454276, result);
		}
		[TestMethod]
		public void MultiplyFloatTest675()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(675, 675);
			Assert.AreEqual(455625, result);
		}
		[TestMethod]
		public void MultiplyFloatTest676()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(676, 676);
			Assert.AreEqual(456976, result);
		}
		[TestMethod]
		public void MultiplyFloatTest677()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(677, 677);
			Assert.AreEqual(458329, result);
		}
		[TestMethod]
		public void MultiplyFloatTest678()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(678, 678);
			Assert.AreEqual(459684, result);
		}
		[TestMethod]
		public void MultiplyFloatTest679()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(679, 679);
			Assert.AreEqual(461041, result);
		}
		[TestMethod]
		public void MultiplyFloatTest680()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(680, 680);
			Assert.AreEqual(462400, result);
		}
		[TestMethod]
		public void MultiplyFloatTest681()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(681, 681);
			Assert.AreEqual(463761, result);
		}
		[TestMethod]
		public void MultiplyFloatTest682()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(682, 682);
			Assert.AreEqual(465124, result);
		}
		[TestMethod]
		public void MultiplyFloatTest683()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(683, 683);
			Assert.AreEqual(466489, result);
		}
		[TestMethod]
		public void MultiplyFloatTest684()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(684, 684);
			Assert.AreEqual(467856, result);
		}
		[TestMethod]
		public void MultiplyFloatTest685()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(685, 685);
			Assert.AreEqual(469225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest686()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(686, 686);
			Assert.AreEqual(470596, result);
		}
		[TestMethod]
		public void MultiplyFloatTest687()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(687, 687);
			Assert.AreEqual(471969, result);
		}
		[TestMethod]
		public void MultiplyFloatTest688()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(688, 688);
			Assert.AreEqual(473344, result);
		}
		[TestMethod]
		public void MultiplyFloatTest689()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(689, 689);
			Assert.AreEqual(474721, result);
		}
		[TestMethod]
		public void MultiplyFloatTest690()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(690, 690);
			Assert.AreEqual(476100, result);
		}
		[TestMethod]
		public void MultiplyFloatTest691()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(691, 691);
			Assert.AreEqual(477481, result);
		}
		[TestMethod]
		public void MultiplyFloatTest692()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(692, 692);
			Assert.AreEqual(478864, result);
		}
		[TestMethod]
		public void MultiplyFloatTest693()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(693, 693);
			Assert.AreEqual(480249, result);
		}
		[TestMethod]
		public void MultiplyFloatTest694()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(694, 694);
			Assert.AreEqual(481636, result);
		}
		[TestMethod]
		public void MultiplyFloatTest695()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(695, 695);
			Assert.AreEqual(483025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest696()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(696, 696);
			Assert.AreEqual(484416, result);
		}
		[TestMethod]
		public void MultiplyFloatTest697()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(697, 697);
			Assert.AreEqual(485809, result);
		}
		[TestMethod]
		public void MultiplyFloatTest698()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(698, 698);
			Assert.AreEqual(487204, result);
		}
		[TestMethod]
		public void MultiplyFloatTest699()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(699, 699);
			Assert.AreEqual(488601, result);
		}
		[TestMethod]
		public void MultiplyFloatTest700()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(700, 700);
			Assert.AreEqual(490000, result);
		}
		[TestMethod]
		public void MultiplyFloatTest701()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(701, 701);
			Assert.AreEqual(491401, result);
		}
		[TestMethod]
		public void MultiplyFloatTest702()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(702, 702);
			Assert.AreEqual(492804, result);
		}
		[TestMethod]
		public void MultiplyFloatTest703()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(703, 703);
			Assert.AreEqual(494209, result);
		}
		[TestMethod]
		public void MultiplyFloatTest704()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(704, 704);
			Assert.AreEqual(495616, result);
		}
		[TestMethod]
		public void MultiplyFloatTest705()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(705, 705);
			Assert.AreEqual(497025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest706()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(706, 706);
			Assert.AreEqual(498436, result);
		}
		[TestMethod]
		public void MultiplyFloatTest707()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(707, 707);
			Assert.AreEqual(499849, result);
		}
		[TestMethod]
		public void MultiplyFloatTest708()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(708, 708);
			Assert.AreEqual(501264, result);
		}
		[TestMethod]
		public void MultiplyFloatTest709()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(709, 709);
			Assert.AreEqual(502681, result);
		}
		[TestMethod]
		public void MultiplyFloatTest710()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(710, 710);
			Assert.AreEqual(504100, result);
		}
		[TestMethod]
		public void MultiplyFloatTest711()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(711, 711);
			Assert.AreEqual(505521, result);
		}
		[TestMethod]
		public void MultiplyFloatTest712()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(712, 712);
			Assert.AreEqual(506944, result);
		}
		[TestMethod]
		public void MultiplyFloatTest713()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(713, 713);
			Assert.AreEqual(508369, result);
		}
		[TestMethod]
		public void MultiplyFloatTest714()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(714, 714);
			Assert.AreEqual(509796, result);
		}
		[TestMethod]
		public void MultiplyFloatTest715()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(715, 715);
			Assert.AreEqual(511225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest716()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(716, 716);
			Assert.AreEqual(512656, result);
		}
		[TestMethod]
		public void MultiplyFloatTest717()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(717, 717);
			Assert.AreEqual(514089, result);
		}
		[TestMethod]
		public void MultiplyFloatTest718()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(718, 718);
			Assert.AreEqual(515524, result);
		}
		[TestMethod]
		public void MultiplyFloatTest719()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(719, 719);
			Assert.AreEqual(516961, result);
		}
		[TestMethod]
		public void MultiplyFloatTest720()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(720, 720);
			Assert.AreEqual(518400, result);
		}
		[TestMethod]
		public void MultiplyFloatTest721()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(721, 721);
			Assert.AreEqual(519841, result);
		}
		[TestMethod]
		public void MultiplyFloatTest722()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(722, 722);
			Assert.AreEqual(521284, result);
		}
		[TestMethod]
		public void MultiplyFloatTest723()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(723, 723);
			Assert.AreEqual(522729, result);
		}
		[TestMethod]
		public void MultiplyFloatTest724()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(724, 724);
			Assert.AreEqual(524176, result);
		}
		[TestMethod]
		public void MultiplyFloatTest725()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(725, 725);
			Assert.AreEqual(525625, result);
		}
		[TestMethod]
		public void MultiplyFloatTest726()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(726, 726);
			Assert.AreEqual(527076, result);
		}
		[TestMethod]
		public void MultiplyFloatTest727()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(727, 727);
			Assert.AreEqual(528529, result);
		}
		[TestMethod]
		public void MultiplyFloatTest728()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(728, 728);
			Assert.AreEqual(529984, result);
		}
		[TestMethod]
		public void MultiplyFloatTest729()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(729, 729);
			Assert.AreEqual(531441, result);
		}
		[TestMethod]
		public void MultiplyFloatTest730()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(730, 730);
			Assert.AreEqual(532900, result);
		}
		[TestMethod]
		public void MultiplyFloatTest731()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(731, 731);
			Assert.AreEqual(534361, result);
		}
		[TestMethod]
		public void MultiplyFloatTest732()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(732, 732);
			Assert.AreEqual(535824, result);
		}
		[TestMethod]
		public void MultiplyFloatTest733()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(733, 733);
			Assert.AreEqual(537289, result);
		}
		[TestMethod]
		public void MultiplyFloatTest734()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(734, 734);
			Assert.AreEqual(538756, result);
		}
		[TestMethod]
		public void MultiplyFloatTest735()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(735, 735);
			Assert.AreEqual(540225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest736()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(736, 736);
			Assert.AreEqual(541696, result);
		}
		[TestMethod]
		public void MultiplyFloatTest737()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(737, 737);
			Assert.AreEqual(543169, result);
		}
		[TestMethod]
		public void MultiplyFloatTest738()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(738, 738);
			Assert.AreEqual(544644, result);
		}
		[TestMethod]
		public void MultiplyFloatTest739()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(739, 739);
			Assert.AreEqual(546121, result);
		}
		[TestMethod]
		public void MultiplyFloatTest740()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(740, 740);
			Assert.AreEqual(547600, result);
		}
		[TestMethod]
		public void MultiplyFloatTest741()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(741, 741);
			Assert.AreEqual(549081, result);
		}
		[TestMethod]
		public void MultiplyFloatTest742()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(742, 742);
			Assert.AreEqual(550564, result);
		}
		[TestMethod]
		public void MultiplyFloatTest743()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(743, 743);
			Assert.AreEqual(552049, result);
		}
		[TestMethod]
		public void MultiplyFloatTest744()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(744, 744);
			Assert.AreEqual(553536, result);
		}
		[TestMethod]
		public void MultiplyFloatTest745()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(745, 745);
			Assert.AreEqual(555025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest746()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(746, 746);
			Assert.AreEqual(556516, result);
		}
		[TestMethod]
		public void MultiplyFloatTest747()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(747, 747);
			Assert.AreEqual(558009, result);
		}
		[TestMethod]
		public void MultiplyFloatTest748()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(748, 748);
			Assert.AreEqual(559504, result);
		}
		[TestMethod]
		public void MultiplyFloatTest749()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(749, 749);
			Assert.AreEqual(561001, result);
		}
		[TestMethod]
		public void MultiplyFloatTest750()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(750, 750);
			Assert.AreEqual(562500, result);
		}
		[TestMethod]
		public void MultiplyFloatTest751()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(751, 751);
			Assert.AreEqual(564001, result);
		}
		[TestMethod]
		public void MultiplyFloatTest752()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(752, 752);
			Assert.AreEqual(565504, result);
		}
		[TestMethod]
		public void MultiplyFloatTest753()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(753, 753);
			Assert.AreEqual(567009, result);
		}
		[TestMethod]
		public void MultiplyFloatTest754()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(754, 754);
			Assert.AreEqual(568516, result);
		}
		[TestMethod]
		public void MultiplyFloatTest755()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(755, 755);
			Assert.AreEqual(570025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest756()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(756, 756);
			Assert.AreEqual(571536, result);
		}
		[TestMethod]
		public void MultiplyFloatTest757()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(757, 757);
			Assert.AreEqual(573049, result);
		}
		[TestMethod]
		public void MultiplyFloatTest758()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(758, 758);
			Assert.AreEqual(574564, result);
		}
		[TestMethod]
		public void MultiplyFloatTest759()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(759, 759);
			Assert.AreEqual(576081, result);
		}
		[TestMethod]
		public void MultiplyFloatTest760()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(760, 760);
			Assert.AreEqual(577600, result);
		}
		[TestMethod]
		public void MultiplyFloatTest761()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(761, 761);
			Assert.AreEqual(579121, result);
		}
		[TestMethod]
		public void MultiplyFloatTest762()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(762, 762);
			Assert.AreEqual(580644, result);
		}
		[TestMethod]
		public void MultiplyFloatTest763()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(763, 763);
			Assert.AreEqual(582169, result);
		}
		[TestMethod]
		public void MultiplyFloatTest764()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(764, 764);
			Assert.AreEqual(583696, result);
		}
		[TestMethod]
		public void MultiplyFloatTest765()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(765, 765);
			Assert.AreEqual(585225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest766()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(766, 766);
			Assert.AreEqual(586756, result);
		}
		[TestMethod]
		public void MultiplyFloatTest767()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(767, 767);
			Assert.AreEqual(588289, result);
		}
		[TestMethod]
		public void MultiplyFloatTest768()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(768, 768);
			Assert.AreEqual(589824, result);
		}
		[TestMethod]
		public void MultiplyFloatTest769()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(769, 769);
			Assert.AreEqual(591361, result);
		}
		[TestMethod]
		public void MultiplyFloatTest770()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(770, 770);
			Assert.AreEqual(592900, result);
		}
		[TestMethod]
		public void MultiplyFloatTest771()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(771, 771);
			Assert.AreEqual(594441, result);
		}
		[TestMethod]
		public void MultiplyFloatTest772()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(772, 772);
			Assert.AreEqual(595984, result);
		}
		[TestMethod]
		public void MultiplyFloatTest773()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(773, 773);
			Assert.AreEqual(597529, result);
		}
		[TestMethod]
		public void MultiplyFloatTest774()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(774, 774);
			Assert.AreEqual(599076, result);
		}
		[TestMethod]
		public void MultiplyFloatTest775()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(775, 775);
			Assert.AreEqual(600625, result);
		}
		[TestMethod]
		public void MultiplyFloatTest776()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(776, 776);
			Assert.AreEqual(602176, result);
		}
		[TestMethod]
		public void MultiplyFloatTest777()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(777, 777);
			Assert.AreEqual(603729, result);
		}
		[TestMethod]
		public void MultiplyFloatTest778()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(778, 778);
			Assert.AreEqual(605284, result);
		}
		[TestMethod]
		public void MultiplyFloatTest779()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(779, 779);
			Assert.AreEqual(606841, result);
		}
		[TestMethod]
		public void MultiplyFloatTest780()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(780, 780);
			Assert.AreEqual(608400, result);
		}
		[TestMethod]
		public void MultiplyFloatTest781()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(781, 781);
			Assert.AreEqual(609961, result);
		}
		[TestMethod]
		public void MultiplyFloatTest782()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(782, 782);
			Assert.AreEqual(611524, result);
		}
		[TestMethod]
		public void MultiplyFloatTest783()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(783, 783);
			Assert.AreEqual(613089, result);
		}
		[TestMethod]
		public void MultiplyFloatTest784()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(784, 784);
			Assert.AreEqual(614656, result);
		}
		[TestMethod]
		public void MultiplyFloatTest785()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(785, 785);
			Assert.AreEqual(616225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest786()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(786, 786);
			Assert.AreEqual(617796, result);
		}
		[TestMethod]
		public void MultiplyFloatTest787()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(787, 787);
			Assert.AreEqual(619369, result);
		}
		[TestMethod]
		public void MultiplyFloatTest788()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(788, 788);
			Assert.AreEqual(620944, result);
		}
		[TestMethod]
		public void MultiplyFloatTest789()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(789, 789);
			Assert.AreEqual(622521, result);
		}
		[TestMethod]
		public void MultiplyFloatTest790()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(790, 790);
			Assert.AreEqual(624100, result);
		}
		[TestMethod]
		public void MultiplyFloatTest791()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(791, 791);
			Assert.AreEqual(625681, result);
		}
		[TestMethod]
		public void MultiplyFloatTest792()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(792, 792);
			Assert.AreEqual(627264, result);
		}
		[TestMethod]
		public void MultiplyFloatTest793()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(793, 793);
			Assert.AreEqual(628849, result);
		}
		[TestMethod]
		public void MultiplyFloatTest794()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(794, 794);
			Assert.AreEqual(630436, result);
		}
		[TestMethod]
		public void MultiplyFloatTest795()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(795, 795);
			Assert.AreEqual(632025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest796()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(796, 796);
			Assert.AreEqual(633616, result);
		}
		[TestMethod]
		public void MultiplyFloatTest797()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(797, 797);
			Assert.AreEqual(635209, result);
		}
		[TestMethod]
		public void MultiplyFloatTest798()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(798, 798);
			Assert.AreEqual(636804, result);
		}
		[TestMethod]
		public void MultiplyFloatTest799()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(799, 799);
			Assert.AreEqual(638401, result);
		}
		[TestMethod]
		public void MultiplyFloatTest800()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(800, 800);
			Assert.AreEqual(640000, result);
		}
		[TestMethod]
		public void MultiplyFloatTest801()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(801, 801);
			Assert.AreEqual(641601, result);
		}
		[TestMethod]
		public void MultiplyFloatTest802()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(802, 802);
			Assert.AreEqual(643204, result);
		}
		[TestMethod]
		public void MultiplyFloatTest803()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(803, 803);
			Assert.AreEqual(644809, result);
		}
		[TestMethod]
		public void MultiplyFloatTest804()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(804, 804);
			Assert.AreEqual(646416, result);
		}
		[TestMethod]
		public void MultiplyFloatTest805()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(805, 805);
			Assert.AreEqual(648025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest806()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(806, 806);
			Assert.AreEqual(649636, result);
		}
		[TestMethod]
		public void MultiplyFloatTest807()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(807, 807);
			Assert.AreEqual(651249, result);
		}
		[TestMethod]
		public void MultiplyFloatTest808()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(808, 808);
			Assert.AreEqual(652864, result);
		}
		[TestMethod]
		public void MultiplyFloatTest809()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(809, 809);
			Assert.AreEqual(654481, result);
		}
		[TestMethod]
		public void MultiplyFloatTest810()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(810, 810);
			Assert.AreEqual(656100, result);
		}
		[TestMethod]
		public void MultiplyFloatTest811()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(811, 811);
			Assert.AreEqual(657721, result);
		}
		[TestMethod]
		public void MultiplyFloatTest812()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(812, 812);
			Assert.AreEqual(659344, result);
		}
		[TestMethod]
		public void MultiplyFloatTest813()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(813, 813);
			Assert.AreEqual(660969, result);
		}
		[TestMethod]
		public void MultiplyFloatTest814()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(814, 814);
			Assert.AreEqual(662596, result);
		}
		[TestMethod]
		public void MultiplyFloatTest815()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(815, 815);
			Assert.AreEqual(664225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest816()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(816, 816);
			Assert.AreEqual(665856, result);
		}
		[TestMethod]
		public void MultiplyFloatTest817()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(817, 817);
			Assert.AreEqual(667489, result);
		}
		[TestMethod]
		public void MultiplyFloatTest818()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(818, 818);
			Assert.AreEqual(669124, result);
		}
		[TestMethod]
		public void MultiplyFloatTest819()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(819, 819);
			Assert.AreEqual(670761, result);
		}
		[TestMethod]
		public void MultiplyFloatTest820()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(820, 820);
			Assert.AreEqual(672400, result);
		}
		[TestMethod]
		public void MultiplyFloatTest821()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(821, 821);
			Assert.AreEqual(674041, result);
		}
		[TestMethod]
		public void MultiplyFloatTest822()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(822, 822);
			Assert.AreEqual(675684, result);
		}
		[TestMethod]
		public void MultiplyFloatTest823()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(823, 823);
			Assert.AreEqual(677329, result);
		}
		[TestMethod]
		public void MultiplyFloatTest824()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(824, 824);
			Assert.AreEqual(678976, result);
		}
		[TestMethod]
		public void MultiplyFloatTest825()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(825, 825);
			Assert.AreEqual(680625, result);
		}
		[TestMethod]
		public void MultiplyFloatTest826()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(826, 826);
			Assert.AreEqual(682276, result);
		}
		[TestMethod]
		public void MultiplyFloatTest827()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(827, 827);
			Assert.AreEqual(683929, result);
		}
		[TestMethod]
		public void MultiplyFloatTest828()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(828, 828);
			Assert.AreEqual(685584, result);
		}
		[TestMethod]
		public void MultiplyFloatTest829()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(829, 829);
			Assert.AreEqual(687241, result);
		}
		[TestMethod]
		public void MultiplyFloatTest830()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(830, 830);
			Assert.AreEqual(688900, result);
		}
		[TestMethod]
		public void MultiplyFloatTest831()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(831, 831);
			Assert.AreEqual(690561, result);
		}
		[TestMethod]
		public void MultiplyFloatTest832()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(832, 832);
			Assert.AreEqual(692224, result);
		}
		[TestMethod]
		public void MultiplyFloatTest833()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(833, 833);
			Assert.AreEqual(693889, result);
		}
		[TestMethod]
		public void MultiplyFloatTest834()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(834, 834);
			Assert.AreEqual(695556, result);
		}
		[TestMethod]
		public void MultiplyFloatTest835()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(835, 835);
			Assert.AreEqual(697225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest836()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(836, 836);
			Assert.AreEqual(698896, result);
		}
		[TestMethod]
		public void MultiplyFloatTest837()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(837, 837);
			Assert.AreEqual(700569, result);
		}
		[TestMethod]
		public void MultiplyFloatTest838()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(838, 838);
			Assert.AreEqual(702244, result);
		}
		[TestMethod]
		public void MultiplyFloatTest839()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(839, 839);
			Assert.AreEqual(703921, result);
		}
		[TestMethod]
		public void MultiplyFloatTest840()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(840, 840);
			Assert.AreEqual(705600, result);
		}
		[TestMethod]
		public void MultiplyFloatTest841()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(841, 841);
			Assert.AreEqual(707281, result);
		}
		[TestMethod]
		public void MultiplyFloatTest842()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(842, 842);
			Assert.AreEqual(708964, result);
		}
		[TestMethod]
		public void MultiplyFloatTest843()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(843, 843);
			Assert.AreEqual(710649, result);
		}
		[TestMethod]
		public void MultiplyFloatTest844()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(844, 844);
			Assert.AreEqual(712336, result);
		}
		[TestMethod]
		public void MultiplyFloatTest845()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(845, 845);
			Assert.AreEqual(714025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest846()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(846, 846);
			Assert.AreEqual(715716, result);
		}
		[TestMethod]
		public void MultiplyFloatTest847()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(847, 847);
			Assert.AreEqual(717409, result);
		}
		[TestMethod]
		public void MultiplyFloatTest848()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(848, 848);
			Assert.AreEqual(719104, result);
		}
		[TestMethod]
		public void MultiplyFloatTest849()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(849, 849);
			Assert.AreEqual(720801, result);
		}
		[TestMethod]
		public void MultiplyFloatTest850()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(850, 850);
			Assert.AreEqual(722500, result);
		}
		[TestMethod]
		public void MultiplyFloatTest851()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(851, 851);
			Assert.AreEqual(724201, result);
		}
		[TestMethod]
		public void MultiplyFloatTest852()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(852, 852);
			Assert.AreEqual(725904, result);
		}
		[TestMethod]
		public void MultiplyFloatTest853()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(853, 853);
			Assert.AreEqual(727609, result);
		}
		[TestMethod]
		public void MultiplyFloatTest854()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(854, 854);
			Assert.AreEqual(729316, result);
		}
		[TestMethod]
		public void MultiplyFloatTest855()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(855, 855);
			Assert.AreEqual(731025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest856()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(856, 856);
			Assert.AreEqual(732736, result);
		}
		[TestMethod]
		public void MultiplyFloatTest857()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(857, 857);
			Assert.AreEqual(734449, result);
		}
		[TestMethod]
		public void MultiplyFloatTest858()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(858, 858);
			Assert.AreEqual(736164, result);
		}
		[TestMethod]
		public void MultiplyFloatTest859()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(859, 859);
			Assert.AreEqual(737881, result);
		}
		[TestMethod]
		public void MultiplyFloatTest860()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(860, 860);
			Assert.AreEqual(739600, result);
		}
		[TestMethod]
		public void MultiplyFloatTest861()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(861, 861);
			Assert.AreEqual(741321, result);
		}
		[TestMethod]
		public void MultiplyFloatTest862()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(862, 862);
			Assert.AreEqual(743044, result);
		}
		[TestMethod]
		public void MultiplyFloatTest863()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(863, 863);
			Assert.AreEqual(744769, result);
		}
		[TestMethod]
		public void MultiplyFloatTest864()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(864, 864);
			Assert.AreEqual(746496, result);
		}
		[TestMethod]
		public void MultiplyFloatTest865()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(865, 865);
			Assert.AreEqual(748225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest866()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(866, 866);
			Assert.AreEqual(749956, result);
		}
		[TestMethod]
		public void MultiplyFloatTest867()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(867, 867);
			Assert.AreEqual(751689, result);
		}
		[TestMethod]
		public void MultiplyFloatTest868()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(868, 868);
			Assert.AreEqual(753424, result);
		}
		[TestMethod]
		public void MultiplyFloatTest869()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(869, 869);
			Assert.AreEqual(755161, result);
		}
		[TestMethod]
		public void MultiplyFloatTest870()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(870, 870);
			Assert.AreEqual(756900, result);
		}
		[TestMethod]
		public void MultiplyFloatTest871()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(871, 871);
			Assert.AreEqual(758641, result);
		}
		[TestMethod]
		public void MultiplyFloatTest872()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(872, 872);
			Assert.AreEqual(760384, result);
		}
		[TestMethod]
		public void MultiplyFloatTest873()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(873, 873);
			Assert.AreEqual(762129, result);
		}
		[TestMethod]
		public void MultiplyFloatTest874()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(874, 874);
			Assert.AreEqual(763876, result);
		}
		[TestMethod]
		public void MultiplyFloatTest875()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(875, 875);
			Assert.AreEqual(765625, result);
		}
		[TestMethod]
		public void MultiplyFloatTest876()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(876, 876);
			Assert.AreEqual(767376, result);
		}
		[TestMethod]
		public void MultiplyFloatTest877()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(877, 877);
			Assert.AreEqual(769129, result);
		}
		[TestMethod]
		public void MultiplyFloatTest878()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(878, 878);
			Assert.AreEqual(770884, result);
		}
		[TestMethod]
		public void MultiplyFloatTest879()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(879, 879);
			Assert.AreEqual(772641, result);
		}
		[TestMethod]
		public void MultiplyFloatTest880()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(880, 880);
			Assert.AreEqual(774400, result);
		}
		[TestMethod]
		public void MultiplyFloatTest881()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(881, 881);
			Assert.AreEqual(776161, result);
		}
		[TestMethod]
		public void MultiplyFloatTest882()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(882, 882);
			Assert.AreEqual(777924, result);
		}
		[TestMethod]
		public void MultiplyFloatTest883()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(883, 883);
			Assert.AreEqual(779689, result);
		}
		[TestMethod]
		public void MultiplyFloatTest884()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(884, 884);
			Assert.AreEqual(781456, result);
		}
		[TestMethod]
		public void MultiplyFloatTest885()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(885, 885);
			Assert.AreEqual(783225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest886()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(886, 886);
			Assert.AreEqual(784996, result);
		}
		[TestMethod]
		public void MultiplyFloatTest887()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(887, 887);
			Assert.AreEqual(786769, result);
		}
		[TestMethod]
		public void MultiplyFloatTest888()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(888, 888);
			Assert.AreEqual(788544, result);
		}
		[TestMethod]
		public void MultiplyFloatTest889()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(889, 889);
			Assert.AreEqual(790321, result);
		}
		[TestMethod]
		public void MultiplyFloatTest890()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(890, 890);
			Assert.AreEqual(792100, result);
		}
		[TestMethod]
		public void MultiplyFloatTest891()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(891, 891);
			Assert.AreEqual(793881, result);
		}
		[TestMethod]
		public void MultiplyFloatTest892()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(892, 892);
			Assert.AreEqual(795664, result);
		}
		[TestMethod]
		public void MultiplyFloatTest893()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(893, 893);
			Assert.AreEqual(797449, result);
		}
		[TestMethod]
		public void MultiplyFloatTest894()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(894, 894);
			Assert.AreEqual(799236, result);
		}
		[TestMethod]
		public void MultiplyFloatTest895()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(895, 895);
			Assert.AreEqual(801025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest896()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(896, 896);
			Assert.AreEqual(802816, result);
		}
		[TestMethod]
		public void MultiplyFloatTest897()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(897, 897);
			Assert.AreEqual(804609, result);
		}
		[TestMethod]
		public void MultiplyFloatTest898()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(898, 898);
			Assert.AreEqual(806404, result);
		}
		[TestMethod]
		public void MultiplyFloatTest899()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(899, 899);
			Assert.AreEqual(808201, result);
		}
		[TestMethod]
		public void MultiplyFloatTest900()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(900, 900);
			Assert.AreEqual(810000, result);
		}
		[TestMethod]
		public void MultiplyFloatTest901()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(901, 901);
			Assert.AreEqual(811801, result);
		}
		[TestMethod]
		public void MultiplyFloatTest902()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(902, 902);
			Assert.AreEqual(813604, result);
		}
		[TestMethod]
		public void MultiplyFloatTest903()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(903, 903);
			Assert.AreEqual(815409, result);
		}
		[TestMethod]
		public void MultiplyFloatTest904()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(904, 904);
			Assert.AreEqual(817216, result);
		}
		[TestMethod]
		public void MultiplyFloatTest905()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(905, 905);
			Assert.AreEqual(819025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest906()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(906, 906);
			Assert.AreEqual(820836, result);
		}
		[TestMethod]
		public void MultiplyFloatTest907()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(907, 907);
			Assert.AreEqual(822649, result);
		}
		[TestMethod]
		public void MultiplyFloatTest908()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(908, 908);
			Assert.AreEqual(824464, result);
		}
		[TestMethod]
		public void MultiplyFloatTest909()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(909, 909);
			Assert.AreEqual(826281, result);
		}
		[TestMethod]
		public void MultiplyFloatTest910()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(910, 910);
			Assert.AreEqual(828100, result);
		}
		[TestMethod]
		public void MultiplyFloatTest911()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(911, 911);
			Assert.AreEqual(829921, result);
		}
		[TestMethod]
		public void MultiplyFloatTest912()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(912, 912);
			Assert.AreEqual(831744, result);
		}
		[TestMethod]
		public void MultiplyFloatTest913()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(913, 913);
			Assert.AreEqual(833569, result);
		}
		[TestMethod]
		public void MultiplyFloatTest914()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(914, 914);
			Assert.AreEqual(835396, result);
		}
		[TestMethod]
		public void MultiplyFloatTest915()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(915, 915);
			Assert.AreEqual(837225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest916()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(916, 916);
			Assert.AreEqual(839056, result);
		}
		[TestMethod]
		public void MultiplyFloatTest917()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(917, 917);
			Assert.AreEqual(840889, result);
		}
		[TestMethod]
		public void MultiplyFloatTest918()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(918, 918);
			Assert.AreEqual(842724, result);
		}
		[TestMethod]
		public void MultiplyFloatTest919()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(919, 919);
			Assert.AreEqual(844561, result);
		}
		[TestMethod]
		public void MultiplyFloatTest920()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(920, 920);
			Assert.AreEqual(846400, result);
		}
		[TestMethod]
		public void MultiplyFloatTest921()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(921, 921);
			Assert.AreEqual(848241, result);
		}
		[TestMethod]
		public void MultiplyFloatTest922()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(922, 922);
			Assert.AreEqual(850084, result);
		}
		[TestMethod]
		public void MultiplyFloatTest923()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(923, 923);
			Assert.AreEqual(851929, result);
		}
		[TestMethod]
		public void MultiplyFloatTest924()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(924, 924);
			Assert.AreEqual(853776, result);
		}
		[TestMethod]
		public void MultiplyFloatTest925()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(925, 925);
			Assert.AreEqual(855625, result);
		}
		[TestMethod]
		public void MultiplyFloatTest926()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(926, 926);
			Assert.AreEqual(857476, result);
		}
		[TestMethod]
		public void MultiplyFloatTest927()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(927, 927);
			Assert.AreEqual(859329, result);
		}
		[TestMethod]
		public void MultiplyFloatTest928()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(928, 928);
			Assert.AreEqual(861184, result);
		}
		[TestMethod]
		public void MultiplyFloatTest929()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(929, 929);
			Assert.AreEqual(863041, result);
		}
		[TestMethod]
		public void MultiplyFloatTest930()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(930, 930);
			Assert.AreEqual(864900, result);
		}
		[TestMethod]
		public void MultiplyFloatTest931()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(931, 931);
			Assert.AreEqual(866761, result);
		}
		[TestMethod]
		public void MultiplyFloatTest932()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(932, 932);
			Assert.AreEqual(868624, result);
		}
		[TestMethod]
		public void MultiplyFloatTest933()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(933, 933);
			Assert.AreEqual(870489, result);
		}
		[TestMethod]
		public void MultiplyFloatTest934()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(934, 934);
			Assert.AreEqual(872356, result);
		}
		[TestMethod]
		public void MultiplyFloatTest935()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(935, 935);
			Assert.AreEqual(874225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest936()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(936, 936);
			Assert.AreEqual(876096, result);
		}
		[TestMethod]
		public void MultiplyFloatTest937()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(937, 937);
			Assert.AreEqual(877969, result);
		}
		[TestMethod]
		public void MultiplyFloatTest938()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(938, 938);
			Assert.AreEqual(879844, result);
		}
		[TestMethod]
		public void MultiplyFloatTest939()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(939, 939);
			Assert.AreEqual(881721, result);
		}
		[TestMethod]
		public void MultiplyFloatTest940()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(940, 940);
			Assert.AreEqual(883600, result);
		}
		[TestMethod]
		public void MultiplyFloatTest941()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(941, 941);
			Assert.AreEqual(885481, result);
		}
		[TestMethod]
		public void MultiplyFloatTest942()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(942, 942);
			Assert.AreEqual(887364, result);
		}
		[TestMethod]
		public void MultiplyFloatTest943()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(943, 943);
			Assert.AreEqual(889249, result);
		}
		[TestMethod]
		public void MultiplyFloatTest944()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(944, 944);
			Assert.AreEqual(891136, result);
		}
		[TestMethod]
		public void MultiplyFloatTest945()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(945, 945);
			Assert.AreEqual(893025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest946()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(946, 946);
			Assert.AreEqual(894916, result);
		}
		[TestMethod]
		public void MultiplyFloatTest947()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(947, 947);
			Assert.AreEqual(896809, result);
		}
		[TestMethod]
		public void MultiplyFloatTest948()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(948, 948);
			Assert.AreEqual(898704, result);
		}
		[TestMethod]
		public void MultiplyFloatTest949()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(949, 949);
			Assert.AreEqual(900601, result);
		}
		[TestMethod]
		public void MultiplyFloatTest950()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(950, 950);
			Assert.AreEqual(902500, result);
		}
		[TestMethod]
		public void MultiplyFloatTest951()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(951, 951);
			Assert.AreEqual(904401, result);
		}
		[TestMethod]
		public void MultiplyFloatTest952()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(952, 952);
			Assert.AreEqual(906304, result);
		}
		[TestMethod]
		public void MultiplyFloatTest953()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(953, 953);
			Assert.AreEqual(908209, result);
		}
		[TestMethod]
		public void MultiplyFloatTest954()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(954, 954);
			Assert.AreEqual(910116, result);
		}
		[TestMethod]
		public void MultiplyFloatTest955()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(955, 955);
			Assert.AreEqual(912025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest956()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(956, 956);
			Assert.AreEqual(913936, result);
		}
		[TestMethod]
		public void MultiplyFloatTest957()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(957, 957);
			Assert.AreEqual(915849, result);
		}
		[TestMethod]
		public void MultiplyFloatTest958()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(958, 958);
			Assert.AreEqual(917764, result);
		}
		[TestMethod]
		public void MultiplyFloatTest959()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(959, 959);
			Assert.AreEqual(919681, result);
		}
		[TestMethod]
		public void MultiplyFloatTest960()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(960, 960);
			Assert.AreEqual(921600, result);
		}
		[TestMethod]
		public void MultiplyFloatTest961()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(961, 961);
			Assert.AreEqual(923521, result);
		}
		[TestMethod]
		public void MultiplyFloatTest962()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(962, 962);
			Assert.AreEqual(925444, result);
		}
		[TestMethod]
		public void MultiplyFloatTest963()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(963, 963);
			Assert.AreEqual(927369, result);
		}
		[TestMethod]
		public void MultiplyFloatTest964()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(964, 964);
			Assert.AreEqual(929296, result);
		}
		[TestMethod]
		public void MultiplyFloatTest965()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(965, 965);
			Assert.AreEqual(931225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest966()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(966, 966);
			Assert.AreEqual(933156, result);
		}
		[TestMethod]
		public void MultiplyFloatTest967()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(967, 967);
			Assert.AreEqual(935089, result);
		}
		[TestMethod]
		public void MultiplyFloatTest968()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(968, 968);
			Assert.AreEqual(937024, result);
		}
		[TestMethod]
		public void MultiplyFloatTest969()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(969, 969);
			Assert.AreEqual(938961, result);
		}
		[TestMethod]
		public void MultiplyFloatTest970()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(970, 970);
			Assert.AreEqual(940900, result);
		}
		[TestMethod]
		public void MultiplyFloatTest971()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(971, 971);
			Assert.AreEqual(942841, result);
		}
		[TestMethod]
		public void MultiplyFloatTest972()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(972, 972);
			Assert.AreEqual(944784, result);
		}
		[TestMethod]
		public void MultiplyFloatTest973()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(973, 973);
			Assert.AreEqual(946729, result);
		}
		[TestMethod]
		public void MultiplyFloatTest974()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(974, 974);
			Assert.AreEqual(948676, result);
		}
		[TestMethod]
		public void MultiplyFloatTest975()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(975, 975);
			Assert.AreEqual(950625, result);
		}
		[TestMethod]
		public void MultiplyFloatTest976()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(976, 976);
			Assert.AreEqual(952576, result);
		}
		[TestMethod]
		public void MultiplyFloatTest977()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(977, 977);
			Assert.AreEqual(954529, result);
		}
		[TestMethod]
		public void MultiplyFloatTest978()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(978, 978);
			Assert.AreEqual(956484, result);
		}
		[TestMethod]
		public void MultiplyFloatTest979()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(979, 979);
			Assert.AreEqual(958441, result);
		}
		[TestMethod]
		public void MultiplyFloatTest980()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(980, 980);
			Assert.AreEqual(960400, result);
		}
		[TestMethod]
		public void MultiplyFloatTest981()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(981, 981);
			Assert.AreEqual(962361, result);
		}
		[TestMethod]
		public void MultiplyFloatTest982()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(982, 982);
			Assert.AreEqual(964324, result);
		}
		[TestMethod]
		public void MultiplyFloatTest983()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(983, 983);
			Assert.AreEqual(966289, result);
		}
		[TestMethod]
		public void MultiplyFloatTest984()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(984, 984);
			Assert.AreEqual(968256, result);
		}
		[TestMethod]
		public void MultiplyFloatTest985()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(985, 985);
			Assert.AreEqual(970225, result);
		}
		[TestMethod]
		public void MultiplyFloatTest986()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(986, 986);
			Assert.AreEqual(972196, result);
		}
		[TestMethod]
		public void MultiplyFloatTest987()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(987, 987);
			Assert.AreEqual(974169, result);
		}
		[TestMethod]
		public void MultiplyFloatTest988()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(988, 988);
			Assert.AreEqual(976144, result);
		}
		[TestMethod]
		public void MultiplyFloatTest989()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(989, 989);
			Assert.AreEqual(978121, result);
		}
		[TestMethod]
		public void MultiplyFloatTest990()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(990, 990);
			Assert.AreEqual(980100, result);
		}
		[TestMethod]
		public void MultiplyFloatTest991()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(991, 991);
			Assert.AreEqual(982081, result);
		}
		[TestMethod]
		public void MultiplyFloatTest992()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(992, 992);
			Assert.AreEqual(984064, result);
		}
		[TestMethod]
		public void MultiplyFloatTest993()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(993, 993);
			Assert.AreEqual(986049, result);
		}
		[TestMethod]
		public void MultiplyFloatTest994()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(994, 994);
			Assert.AreEqual(988036, result);
		}
		[TestMethod]
		public void MultiplyFloatTest995()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(995, 995);
			Assert.AreEqual(990025, result);
		}
		[TestMethod]
		public void MultiplyFloatTest996()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(996, 996);
			Assert.AreEqual(992016, result);
		}
		[TestMethod]
		public void MultiplyFloatTest997()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(997, 997);
			Assert.AreEqual(994009, result);
		}
		[TestMethod]
		public void MultiplyFloatTest998()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(998, 998);
			Assert.AreEqual(996004, result);
		}
		[TestMethod]
		public void MultiplyFloatTest999()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(999, 999);
			Assert.AreEqual(998001, result);
		}
		[TestMethod]
		public void MultiplyFloatTest1000()
		{
			var sut = new Multiplier();
			double result = sut.MultiplyFloats(1000, 1000);
			Assert.AreEqual(1000000, result);
		}

	}
}
