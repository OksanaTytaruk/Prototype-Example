# Prototype Example

Цей репозиторій містить приклад патерну проектування "Прототип".

## Патерн Прототип (Prototype)

Патерн "Прототип" дозволяє створювати нові об'єкти шляхом клонуєання вже існуючих, що дозволяє зекономити ресурси та час.

### Приклад коду:

```csharp
// Prototype
public abstract class Shape
{
    public string Color { get; set; }
    public abstract Shape Clone();
}
