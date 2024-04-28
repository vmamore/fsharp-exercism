module CarsAssemble
    let succesRate (speed: int) : float =
        match speed with
        | 0 -> 0
        | x when x >= 1 && x <= 4 -> 1
        | x when x >= 5 && x <= 8 -> 0.9
        | 9 -> 0.8
        | 10 -> 0.77
        | _ -> failwith "Speed must be between 0 and 10."

    let successRateIf (speed: int) : float =
        if speed = 0 then 0.0
        elif speed <= 4 then 1.00
        elif speed <= 8 then 0.90
        elif speed = 9 then 0.0
        else 0.77

    let productionRatePerHour (speed: int) : float =
        221.0 * float speed * succesRate speed

    let workingItemsPerMinute (speed: int) : int =
        int (productionRatePerHour speed / 60.0)