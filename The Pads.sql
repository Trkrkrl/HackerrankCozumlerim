Select Concat (Name,'(',left(occupation,1),')') --concat ile metinleri birlestirir- left ile soldan ilk harfi alır

From Occupations
order by name asc;--isimleri sırasıyla listeler
--

select 'There are a total of ' ,count(occupation) ,concat(lower(occupation), 's.') -- there are 3 doctors seklinde yazilari yazdirir
from occupations
group by occupation
order by count(occupation) asc
