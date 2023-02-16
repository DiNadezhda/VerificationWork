# Verification Work

Для составления программы написано 3 метода:
* Метод для ввода значений в массив с клавиатуры
* Метод, создающий новый массив путём отсеивания элементов, неподходящих по размеру
* Метод вывода массива на печать

### *Метод для ввода значений в массив с клавиатуры*
Перебором элементов программа спрашивает у пользователя название элемента для конкретной позиции массива. На входе в этот метод нам необходимо только количество элементов будущего массива. На выходе из этого метода мы получаем массив типа **string**

### *Метод, создающий новый массив путём отсеивания элементов, неподходящих по размеру*
Берем массив, полученный предыдущим методом и проверяем каждый элмент на соответствие условию. Если длина элемента более заданного нами числа, то это число попадает в новый массив.

### *Метод вывода массива на печать*
При выводе на печать этот метод проверяет пустое ли значение элемента. если значение пустое (null), то не выводятся лишние запятые и пробелы.

По условию, необходимо вывести исходиный массив и новый массив в одну строчку с разделителем "->". Условие по оформлению выполнено идеально.
______________________
*PS: Не стала обрамлять каждый элемент кавычками, так как показалось, что это затрудняет чтение информации. Надеюсь, что это не ошибка. В любом случае, кавычки можно просто добавить в метод вывода массива на печать.*