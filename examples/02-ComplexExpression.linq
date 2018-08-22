<Query Kind="Expression" />

(from x in Enumerable.Range(0, 10)
from y in Enumerable.Range(0, 10)
select x * y).Sum()