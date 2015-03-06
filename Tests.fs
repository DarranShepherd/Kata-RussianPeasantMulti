module Tests

open RussianPeasantMultiplication

open NUnit.Framework

[<Test>]
let ``When 1 is multipled by 1 expect 1``() =
    Assert.AreEqual(1, multiply 1 1)

[<Test>]
let ``When 1 is multipled by 2 expect 2``() =
    Assert.AreEqual(2, multiply 1 2)

[<Test>]
let ``When 2 is multipled by 1 expect 2``() =
    Assert.AreEqual(2, multiply 2 1)

[<Test>]
let ``When 3 is multipled by 4 expect 12``() =
    Assert.AreEqual(12, multiply 3 4)

[<Test>]
let ``When 3 is multipled by 5 expect 15``() =
    Assert.AreEqual(15, multiply 3 5)

[<Test>]
let ``When 4 is multipled by 6 expect 24``() =
    Assert.AreEqual(24, multiply 4 6)

[<Test>]
let ``When 4 is multipled by 7 expect 28``() =
    Assert.AreEqual(28, multiply 4 7)

[<Test>]
let ``When 18 is multipled by 23 expect 414``() =
    Assert.AreEqual(414, multiply 18 23)
