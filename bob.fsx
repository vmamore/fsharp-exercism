module Bob

open System

let response (input: string): string = 
    let allUpperCase = input.Trim().ToCharArray()[1..] |> Seq.forall(fun x -> (Char.IsLetter(x) && Char.IsUpper(x)) || (true))
    let containLetter = input.Trim().ToCharArray() |> Seq.exists(fun x -> Char.IsLetter(x))
    let isYelling = containLetter && allUpperCase
    let isQuestion = input.Trim().EndsWith("?")
    let isSilence = input.Trim() = ""
    match (isQuestion, isYelling, isSilence) with
    | (true, false, false) -> "Sure."
    | (false, true, false) -> "Whoa, chill out!"
    | (true, true, false) -> "Calm down, I know what I'm doing!"
    | (_, _, true) -> "Fine. Be that way!"
    | _ -> "Whatever."

let message = response "ZOMG THE %^*@#$(*^ ZOMBIES ARE COMING!!11!!1!"

printfn "%s" message