open Domain
open Services

[<EntryPoint>]
let main argv =
    let foo = {
        A = 1
        B = "2"
    }
    let fooPrinter = FooPrinter() :> IFooPrinter
    fooPrinter.PrintFoo(foo)
    0
