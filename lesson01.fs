let days_in_month = function
| n when n < 1 || n > 12  -> 0
| n -> System.DateTime.DaysInMonth(System.DateTime.Now.Year, n)
