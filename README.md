 ```mermaid
classDiagram
class Cell {
    -Charge: float
    -Name: string
    -Level: int
    +Cell(string name, float charge = 200)
    +Consume(float amount) void
    +Restore() void
    

}

```