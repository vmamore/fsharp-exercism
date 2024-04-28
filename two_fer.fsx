let twoFer (nameOpt: string option) : string =
    let name = Option.defaultValue "you" nameOpt
    $"One for {name}, one for me."


let name = Some "Bob"
let response = twoFer None
printfn "%s" response
let responseWithName = twoFer name
printfn "%s" responseWithName


let twoFerTwo (nameOpt: string option) : string =
    let name = 
        match nameOpt with
        | Some name -> name
        | None -> "you"
    $"One for {name}, one for me."

let twoFerThree (nameOpt: string option) : string =
    nameOpt |>
    Option.defaultValue "you" |>
    sprintf "One for %s, one for me."


twoFerThree name
twoFerThree None
        