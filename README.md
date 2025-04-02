# C# Sealed Modifier

A quick reference guide for the sealed modifier in C#.

## Index 📋 
- [A. Sealed Classes](#a-sealed-classes)
- [B. Sealed Methods](#b-sealed-methods)
- [C. Sealed Properties](#c-sealed-properties)
- [D. Code Example](#d-code-example)

## A. Sealed Classes

- **Purpose:** Prevents other classes from inheriting from the sealed class
- **Usage:** Applied to derived classes to prevent further inheritance
- **Syntax:** `sealed class ClassName : BaseClass { }`

## B. Sealed Methods

- **Purpose:** Prevents derived classes from further overriding a method
- **Usage:** Applied to override methods in derived classes
- **Syntax:** `sealed override void MethodName() { }`
- **Requirement:** Can only be used with the `override` keyword on methods that are overriding a virtual method

## C. Sealed Properties

- **Purpose:** Prevents derived classes from further overriding a property
- **Usage:** Applied to override properties in derived classes
- **Syntax:** `sealed override Type PropertyName { get; set; }`
- **Requirement:** Can only be used with the `override` keyword on properties that are overriding a virtual property

## Notes

When using the sealed modifier:

1. **For derived classes**: Prevents any other class from inheriting from that sealed class
2. **For derived properties**: Prevents any other property from overriding that virtual property in a base class
3. **For derived methods**: Prevents any other method from overriding that virtual method in a base class

## Best Practices 🥇

- Use sealed classes when you want to prevent inheritance for security reasons or to ensure that the design of the class is not compromised
- Use sealed methods and properties when you have implemented an override that should not be further customized in derivative classes
- Consider performance implications - the compiler can optimize calls to sealed classes and members
- Don't overuse - sealing can limit extensibility of your code


# Final Note: 
- A sealed class does not allow other classes to derive from itself, but a sealed class can inherit from another class.

