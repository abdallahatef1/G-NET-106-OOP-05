namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            #region Q1 Object Copying


            #region a) What happens when you assign one object variable to another object variable?
            //Only the reference is copied. Both variables end up pointing to the same object in memory.

            #endregion

            #region b) Does assigning one object to another create a new object? Explain.
            //No, it does not create a new object. It only copies the reference to the existing object.

            #endregion

            #region c) What is the difference between copying an object and copying its reference?
            //Copying an object creates a new instance of the object with the same values, while copying a reference only copies the address of the existing object in memory.


            #endregion

            #endregion

            #region Q2 Shallow Copy vs Deep Copy

            #region a) What is a Shallow Copy?
            //A shallow copy creates a new object, but it copies the references of the original object's fields. If the original object has reference-type fields

            #endregion

            #region b) What is a Deep Copy?
            //A deep copy creates a new object and also creates new instances of the original object's fields, recursively copying all objects referenced by the original object.

            #endregion

            #region c) What happens to reference-type members when a Shallow Copy is created?
            //When a shallow copy is created, the reference-type members of the original object are copied as references
            #endregion

            #region d) What happens to reference-type members when a Deep Copy is created?
            //When a deep copy is created, new instances of the reference-type members are created, and the values of the original object's fields are copied to these new instances.
            #endregion

            #region e) Give one situation where Deep Copy would be safer than Shallow Copy.
            // changing a copied shipment's delivery address without accidentally changing the original shipment's address too.
            #endregion


            #endregion

            #region  Q3  Static Members

            #region a) What is a static field, and how is it different from an instance field?
            //A static field is a variable that is shared among all instances of a class, while an instance field is unique to each instance of the class.

            #endregion

            #region b) What is a static method? Can a static method directly access instance members?
            //A static method is a method that belongs to the class itself rather than an instance of the class. A static method cannot directly access instance members because it does not have a reference to a specific instance of the class.

            #endregion

            #region c) What is a static constructor, and when is it executed?
            //A static constructor is a special constructor that initializes static members of a class. It is executed only once, when the class is first accessed or instantiated.
            #endregion

            #region d) What is a static class? Can you create an object from a static class?
            //A static class is a class that cannot be instantiated and can only contain static members. You cannot create an object from a static class.

            #endregion

            #endregion

            #region Q4  Extension Methods

            #region a) What is an Extension Method?
            //An extension method is a static method that allows you to add new functionality to existing types without modifying their source code or creating a new derived type.

            #endregion

            #region b) What keyword must be used in the first parameter of an extension method?
            //The "this" 


            #endregion

            #region c) Where must an extension method be declared?
            //An extension method must be declared in a static class.
            #endregion

            #region d) Can an extension method access private members of the class it extends?
            //No, an extension method cannot access private members of the class it extends. It can only access public and protected members

            #endregion

            #endregion

            #region Q5  Partial Classes and Partial Methods

            #region a) What is a Partial Class?
            //A partial class is a class that can be split into multiple files, allowing for better organization and separation of concerns.

            #endregion

            #region b) Why would a developer split one class into multiple files?
            //A developer might split a class into multiple files to improve code organization, maintainability, and collaboration among team members.

            #endregion

            #region c) What is a Partial Method?
            // A method declared with no body in one part of a partial class, which may optionally be given a body in another part of the same class.

            #endregion

            #region d) What happens if a declared partial method has no implementation?
            //The compiler removes the declaration and every call to it entirely, with no error and no runtime cost.

            #endregion

            #endregion

            #endregion



        }
    }
}
