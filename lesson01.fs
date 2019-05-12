// 7.1.1
let rec fibo = function 
| n when n < 2 -> n
| n -> (fibo(n-1) + fibo(n-2))

// 7.1.2
let rec sum = function
| n when n < 2 -> 1
| n -> (sum(n-1) + n)

// 7.1.3
let rec sum2 = function 
 | (m,0) -> m
 | (m,n) -> m + sum2(m, n-1)
