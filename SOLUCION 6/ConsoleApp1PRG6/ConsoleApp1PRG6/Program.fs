// Learn more about F# at http://fsharp.org

open System
let funsuma a b =a+b
let funresta a b =a-b
let funmultiplicacion a b =a * b
let fundivi a b =float (a/b)
[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    Console.WriteLine("introduca primer numero numeros")
    let digito1=Console.ReadLine()
    Console.WriteLine("introduca segundo numero numeros")
    let digito2=Console.ReadLine()

    //convertir
    let dif1=Convert.ToInt32(digito1)
    let dif2=Convert.ToInt32(digito2)
    let valorsuma=funsuma dif1 dif2
    Console.WriteLine("la suma "+valorsuma.ToString() )
    let valorresta=funresta dif1 dif2
    Console.WriteLine("la resta "+valorresta.ToString() )
    let valormulti=funmultiplicacion dif1 dif2
    Console.WriteLine("la multiplicacion "+valormulti.ToString() )
    let valordivi=fundivi dif1 dif2
    Console.WriteLine("la divicion "+valordivi.ToString() )
    let techa= Console.ReadKey()
    0 // return an integer exit code
