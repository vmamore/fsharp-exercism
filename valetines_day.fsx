module ValentinesDay

// TODO: please define the 'Approval' discriminated union type
type Approval = 
    | Yes
    | No
    | Maybe

// TODO: please define the 'Cuisine' discriminated union type
type Cuisine =
    | Turkish
    | Korean

// TODO: please define the 'Genre' discriminated union type
type Genre =
    | Crime
    | Horror
    | Romance
    | Thriller
// TODO: please define the 'Activity' discriminated union type
type Activity =
    | BoardGame
    | Chill
    | Movie of Genre
    | Restaurant of Cuisine
    | Walk of int

let rateActivity (activity: Activity): Approval = 
    match activity with
        | BoardGame -> Approval.No
        | Chill -> Approval.No
        | Movie m -> match m with | Romance -> Approval.Yes | _ -> Approval.No
        | Restaurant r -> match r with | Korean -> Approval.Yes | _ -> Approval.Maybe
        | Walk w -> match w with | w when w < 3 -> Approval.Yes | w when w < 5 -> Approval.Maybe | _ -> Approval.No

let rateActivity2 (activity: Activity): Approval = 
    match activity with 
        | BoardGame -> No
        | Chill -> No
        | Movie Romance -> Yes
        | Movie _ -> No
        | Restaurant Korean -> Yes
        | Restaurant Turkish -> Maybe
        | Walk km when km < 3 -> Yes
        | Walk km when km < 5 -> Maybe
        | Walk _ -> No