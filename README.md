patterns
========

set of differnt programming patterns

    Шаблоны:
Основные:

1)Делегирование (Delegation pattern) - объект внешне выражает некоторое поведение, но в реальности
передает ответственность за выполнение этого поведения связанному объекту.

2)Функциональный дизайн (Functional design pattern) - каждый модуль имеет свою обязанность.

3)Неизменяемый объект (Immutable pattern) - обект не может быть изменен после создания. (const или string в C#)

4)Интерфейс (Interface pattern) - класс обеспечивающий доступ к другим классам.

5)Пользовательские атрибуты (Marker Interface pattern) (custom attributes) - атрибуты для добавления метаданных.
Примеры: WCF

6)Контейнер Container (collections) - контейнер, представляет группу объектов как один объект с итератором.

7)Контейнер свойств (Property Container pattern_ - Интерфейс позволяющий создавать, удалять, перезаписывать свойства. 
в наследуемых классах.

8)Event Channel pattern - обобщенный P\S шаблон с централизованным каналом для событий.

Порождающие:

9) Абстрактная фабрика (Abstract Factory pattern)  - интерфейс для создания  семейств взаимосвязанных объектов

10) Строитель (Builder pattern)  - вынесение алгоритма создания сложного объекта в отдельный класс

11) Фабричный метод (Factory Method pattern) - 

12) Отложенная инициализация (Lazy initialization pattern) - инициализация объекта при обращении к нему

13) Прототип (Prototype pattern) - создание экземпляра класса с помощью прототипирования

14) Получение ресурса есть инициализация (RAII pattern) - при получении объекта он инициализируется, а при освобождении уничтожается

15) Одиночка (Singleton pattern) - класс, имеющий только один экземпляр в программе
