****
# :star2:  `Factory method`

### :black_nib:	����������� �� ������������ �������
##### **��������� �����** � �� �������������� ������ ������������, ���� ������� ��������� ��������� ��� ��������� �ᒺ��� � ������������ ����, ���������� �������� �������� ��� ����������� �ᒺ���.
��� ������ � ��������� ��������� **Open-Closed Principle SOLID**, �� ���� ������� �������� ��� ���������� (��������� ��������), ��� �������� ��� ����.
##### **������������� ��� :**
- *��������*, ���� ��������� ��������� �������� ����� ����� ��� ���� ��������� ����;
- *³����������� ���� �볺��� �� ���������� �����, ���������� ���� �� �������.* ������ ��������� �ᒺ��� �� ��������� ������������ �볺������� ��� ����������� �� ��������� � ��������� �������, ��� ���� ���������� ����� �� ��������� �� ��� �볺���.
- *������������� ������� ���������� �� ��������.* ���� � �������� ����� � ��������� ���������� ������������� �� ��������� ���������� �ᒺ��� ��������, ���� ������ ������������� ������ ��������� ���������� ������ ��� ��������� �ᒺ���, ������������ �������� ���������, ��������� ����������� ������.
- *����������� ��������� �������.* ������ ����, ��� ������������� ���������� �ᒺ���, ���� ����������� �� ��������� ����� ��� ��������� ���������� ���� �����������. �� ������� ����� ����������� ��� ������������ ������� � ������ �����������, �� ������� ����, ���� �� �����������.

### ĳ������ ����� �� �����

##### Class Diagram Factory Method:
```mermaid
---
title: Factory Method
---
classDiagram
    Creator <|-- ConcreteCreator
    IProduct <|.. ConcreteProduct: realization
    ConcreteProduct <|-- ConcreteCreator: return new ConcreteProduct()
    note for Creator "IProduct p = factoryMethod() \n p.someOperation()"
    Creator : ...
    ConcreteCreator : ...
    class Creator{
      +factoryMethod() IProduct
      +someOperation()
    }
    class ConcreteCreator{
      +factoryMethod() IProduct
    }
    class IProduct{
        <<interface>>
        +someOperation()
    }
```

##### State Diagram Factory Method:
```mermaid
---
title: Factory Method
---
stateDiagram
    direction LR
    [*] --> Client
    Client --> [*]

    state Client {
        [*] --> Load
        Load --> Ready
        Ready --> [*]
        Ready --> Create
        Create --> ShowMessage
        ShowMessage --> ShowMessageWithImage
        ShowMessageWithImage --> ClearImage
        ClearImage --> Ready
    }
```

### ���� �������� ����������� �������� :
- **Product** - ��������� ��������� �ᒺ���, �� ���� ���������� ������� �� ���� �������;
- **ConcreteProduct** ������ ��� ����� ��������. ³������������� ����������, ��� ��������� � ��� ���� �������;
- **Creator** (��������� ��� ����������� ����) ������� ��������� �����, ���� �� ��������� ��� �ᒺ��� ��������. �������, ��� ��� ���������� ����� ������ �������� �� ��������� ����������� ��������.
- **ConcreteCreator** ��-����� ������ ��������� �����, ���������� � �� ���� �������� ��������.
##### �� ������ ����� ����� �������� �������� ����� �� ������� Factory method.

### ������� ����������
##### - [URL1](https://refactoring.guru/design-patterns/factory-method)
##### - [URL2](https://blog.stackademic.com/design-patterns-factory-method-2f7b0733286d)
##### - [URL3](https://www.baeldung.com/java-factory-pattern)
****