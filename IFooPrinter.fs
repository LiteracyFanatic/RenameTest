namespace Services

open Domain

type IFooPrinter =
    abstract PrintFoo: foo: Foo -> unit
