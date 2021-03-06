# Тестовое задание от Mindbox

## Задание 1

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным

### Ход мысли

Выбрал .Net Core Class Library, потому что кроссплатформенна, 3.1 - потому что LTS.

Исходя из [этого сравнения](https://www.lambdatest.com/blog/nunit-vs-xunit-vs-mstest/) выбрал xUnit для юнит тестов.

В ТЗ не указано, каким должно быть API, поэтому оставил и ООП, и обёртку статическими методами.

### Результат

- [x] Вычисляет площадь круга по радиусу
- [x] Вычисляет площадь треугольника по трем сторонам
- [x] Юнит тесты
- [ ] Лёгкость добавления фигур - не ясно. Нужен ли алгоритм для любых многоугольников? Сейчас все замкнутые фигуры реализуют `IEnclosedShape`
- [x] Вычисление площади фигуры без знания типа фигуры в compile-time - если фигура реализует IEnclosedShape
- [x] Проверка на то, является ли треугольник прямоугольным
