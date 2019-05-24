open System
[<EntryPoint>]
let main argv=
  


    printf "Enter first string: "
    let mutable first = Console.ReadLine();
    printf "Enter 2nd string: "
    let mutable second = Console.ReadLine();



  // first.ToCharArray
   // second.ToCharArray


    let function1() =

      for i in first do

            for j in second do

            if i = j then 
               (* printf "%s" first.[0..first.IndexOf(i)]
             
                printf "%d" first.Length


                printf "%s" second.[0..second.IndexOf(j)]
                printf "%s" second.[second.IndexOf(j) + 1..second.Length - 1]
                printf "\n" *)


                first <- first.[0..first.IndexOf(i) - 1] + first.[first.IndexOf(i) + 1..first.Length - 1]
                second <- second.[0..second.IndexOf(j) - 1] + second.[second.IndexOf(j) + 1..second.Length - 1]

                printf "%s" first
                printf "\n"
                printf "%s" second
                printf "\n"
            

     (* printfn "%s" first
      printfn "%s" second *)

    function1()

    printf "Result: %s" first
    printf "%s" second

    0 // return an integer exit code
