Итоговая проверочная работа.
Яцунов Юрий Михайлович

Задание:
Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. При решении не
рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Начал с блоксхемы, которая находится в этой же папке в виде картинки.

В связи с тем, что программа довольно маленькая, то никаких комментариев к решению я не писал, потому что читается очень просто.


Я использовал для преобразования массива Resize, но если этим нельзя пользоваться, то я бы задачу решил примерно так:
Создать массив
Заполнить случайными числами
Пройтись циклом по массиву и вычислить, сколько в нём четных чисел
Создать новый массив нужного размера
Еще раз пройтись по начальнуму массиву циклом и забрать оттуда все четные числа в новый массив