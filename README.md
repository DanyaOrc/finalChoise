# Итоговая работа

## Задача : 

### Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

## Описание алгоритма решения:

### Сначало объявляется два массива равной длины. Потом объявляем метод, в котором находится соразмерный длине массива цикл с проверкой условия ( <=3 ), если ответ на проверку – "да", то элемент первого массива заносится в count второго массива. Переменная count нам нужна для верного подсчёта. После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. Таким образом мы перебираем значения и проводим проверку до конца.

### Графическое представление метода в папке diagrams

### Реализация алгоритма по пути taskF/Program.cs