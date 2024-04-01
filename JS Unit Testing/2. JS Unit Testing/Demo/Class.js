class Person 
{
    constructor(name) 
    {
      this.name = name;
    }
  
    sayHello() 
    {
      console.log(`Hello, my name is ${this.name}.`);
    }
  }
  
  const john = new Person("John");
  john.sayHello();
  