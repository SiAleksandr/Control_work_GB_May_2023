# Описание работы программы
## По порядку выполняются методы
## 1. InputInt
Этот метод принимает и выводит на экран сообщение пользователю, что нужно ввести длину будущего массива. Далее метод возвращает введённое число в переменную _**length**_.
## 2. Check
Этот метод принимает переменную _**length.**_ Если она не больше нуля, то выводится сообщение и программа заканчивает работу. Если больше нуля, то выполнение продолжается. Метод ничего не возвращает.
## 3. CreateArray
Метод принимает переменную _**length**_ как длину массива и создаёт такой массив. Потом пользователю выводится сообщение, что нужно заполнить по очереди элементы массива наборами символов. Выполняется цикл, в котором пользователь заполняет все элементы массива от перого до последнего. Метод возвращает этот массив.
## 4. GetFinalArray
Метод принимает заполненный ранее массив и создаёт ещё один массив такой же длины. Потом выполняется цикл, в котором перебираются все элементы исходного массива. Берётся количество символов в очередном элементе и сравнивается с числом 3. Если оно не больше, то элементу нового массива присваивается содержимое проверенного элемента, и ещё переменная _**count**_, которая сначала была равна нулю, увеличивается на единицу. Она берётся как индекс элемента в новом массиве. И ещё в ней считается количество элементов, содержащее не более трёх символов. Если таких нет, то выводится сообщение об этом, то есть если _**count**_ равна нулю. Если не равна, то после первого цикла создаётся третий массив из равного хранящемуся в переменной _**count**_ числу элементов. Потом ещё один цикл перебирает все элементы третьего массива и сохраняет в них содержимое элементов второго массива, то есть берутся элементы с равными индексами. Третий массив - это полученное решение задачи. Чтобы не создавать третий цикл, значения элементов найденного массива выводятся на экран в каждой итерации второго цикла.