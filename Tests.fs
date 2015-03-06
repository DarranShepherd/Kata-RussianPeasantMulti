module Tests

open NUnit.Framework
open RussianPeasantMultiplication

[<Test>]
let ``Identity for multiplication`` =
    Assert.AreEqual(1, multiply 1 1)

[<Test>]
let ``Simplest non-identity multiplication`` =
    Assert.AreEqual(2, multiply 1 2)

[<Test>]
let ``Checking for commutative propert by reversing argument order`` =
    Assert.AreEqual(2, multiply 2 1)

[<Test>]
let ``Smaller number odd, larger number even``() =
    Assert.AreEqual(12, multiply 3 4)

[<Test>]
let ``Both numbers odd``() =
    Assert.AreEqual(15, multiply 3 5)

[<Test>]
let ``Both numbers even``() =
    Assert.AreEqual(24, multiply 4 6)

[<Test>]
let ``Smaller number even, larger number odd``() =
    Assert.AreEqual(28, multiply 4 7)

[<Test>]
let ``First argument negative, second positive``() =
    Assert.AreEqual(-10, multiply -2 5)

[<Test>]
let ``First argument positive, second negative``() =
    Assert.AreEqual(-12, multiply 3 -4)

[<Test>]
let ``Both arguments negative``() =
    Assert.AreEqual(24, multiply -4 -6)

[<Test>]
let ``The problem example``() =
    Assert.AreEqual(414, multiply 18 23)

[<TestCase(1,   1, 1)>]   // Identity for multiplication
[<TestCase(1,   2, 2)>]   // Simplest non-identity multiplication
[<TestCase(2,   1, 2)>]   // Checking for commutative propert by reversing argument order
[<TestCase(3,   4, 12)>]  // Smaller number odd, larger number even
[<TestCase(3,   5, 15)>]  // Both numbers odd
[<TestCase(4,   6, 24)>]  // Both numbers even
[<TestCase(4,   7, 28)>]  // Smaller number even, larger number odd
[<TestCase(-2,  5,-10)>]  // First argument negative, second positive
[<TestCase(3,  -4,-12)>]  // First argument positive, second negative
[<TestCase(-4, -6, 24)>]  // Both arguments negative
[<TestCase(18, 23, 414)>] // The problem example
let ``When x is multipled by y expect expected`` x y expected =
    Assert.AreEqual(expected, multiply x y)