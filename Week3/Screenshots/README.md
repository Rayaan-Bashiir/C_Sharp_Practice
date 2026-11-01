# Week 3 Practice – Making Decisions 

## 1. Using the if Statement

The `if` statement executes code when a condition is true.

### Code

```csharp
private void checkButton_Click(object sender, EventArgs e)
{
    double sales = 60000;
    double bonus = 0;

    if (sales > 50000)
    {
        bonus = 500;
    }

    MessageBox.Show("Bonus: " + bonus);
}
```

## 2. Using the if-else Statement

The `if-else` statement executes one block when the condition is true and another block when it is false.

### Code

```csharp
private void resultButton_Click(object sender, EventArgs e)
{
    int testScore = 75;

    if (testScore >= 50)
    {
        MessageBox.Show("Pass");
    }
    else
    {
        MessageBox.Show("Fail");
    }
}
```

## 3. Using Nested if Statements

A nested `if` statement is an `if` statement inside another `if` statement. It checks multiple conditions.

### Code

```csharp
private void checkButton_Click(object sender, EventArgs e)
{
    int age = 20;
    int testScore = 80;

    if (age >= 18)
    {
        if (testScore >= 50)
        {
            MessageBox.Show("Accepted");
        }
    }
}
```

## 4. Using Logical Operators

Logical operators combine or reverse conditions.

- `&&` means AND.
- `||` means OR.
- `!` means NOT.

### Code

```csharp
private void checkButton_Click(object sender, EventArgs e)
{
    int age = 20;
    int score = 80;

    if (age >= 18 && score >= 50)
    {
        MessageBox.Show("Both conditions are true.");
    }
}
```

## Conclusion

This week covers decision structures, including `if`, `if-else`, nested `if` statements, and logical operators in C#.