module InterestIsInteresting

open System

let interestRate (balance: decimal): single =
    if balance < 0m then 3.213f
    elif balance < 1000m then 0.5f
    elif balance >= 1000m && balance < 5000m then 1.621f
    else 2.475f

let interest (balance: decimal): decimal =
   decimal (interestRate balance / 100f) * balance

let annualBalanceUpdate(balance: decimal): decimal =
   balance + interest balance

let amountToDonate(balance: decimal) (taxFreePercentage: float): int =
    if balance < 0m then int 0
    else 
        let tax = balance * (decimal taxFreePercentage / 100.0m) * 2.0m
        int tax