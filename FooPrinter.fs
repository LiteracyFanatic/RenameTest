namespace Services

open Domain

type FooPrinter() =
    interface IFooPrinter with
        member this.PrintFoo(foo: Foo) =
            printfn $"A = %i{foo.A}, B = %s{foo.B}"
