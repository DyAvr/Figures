# Figures

Реализация фигур с функцией нахождения их площади

## Ответ на задание с SQL

SELECT p.Name AS 'Имя продукта', c.Name AS 'Имя категории'

FROM Products p

LEFT JOIN Category c ON p.category_id = c.id;
