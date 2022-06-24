# .NET Core Service Life Cycle Demo

## How to Run the Project

```
git clone https://github.com/jwlin/dotnetcore-service-lifecycle-demo.git
cd dotnetcore-service-lifecycle-demo
dotnet run
```

Go to https://localhost:7197/demo (the port may vary), you will see something like:

![image](https://user-images.githubusercontent.com/5249835/175568538-4e2dd90e-8cdb-4129-82fc-6f5ed35bec38.png)

Which clearly shows the life time of the objects when you add them with different lifecycle (Transient, Scoped, and Singleton)

For more info about this example please refer to [this blog post](https://jimoncode.com/dotnet-core-service-life-cycle/) (in Chinese)
