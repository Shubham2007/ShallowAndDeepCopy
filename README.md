There are numerous ways to implement a DEEP COPY operation if the shallow copy operation performed by the MemberwiseClone method does not meet your needs. These include the following:

    1) Call a class constructor of the object to be copied to create a second object with property values taken from the first object. This        assumes that the values of an object are entirely defined by its class constructor.

    2) Call the MemberwiseClone method to create a shallow copy of an object, and then assign new objects whose values are the same as the        original object to any properties or fields whose values are reference types. The DeepCopy method in the example illustrates this          approach.

    3) Serialize the object to be deep copied, and then restore the serialized data to a different object variable.

    4) Use reflection with recursion to perform the deep copy operation.
