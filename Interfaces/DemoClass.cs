namespace LifeCycleDemo.Interface;

public interface IScoped { }
public interface ISingleton { }
public interface ITransient { }

public class DemoClass : IScoped, ISingleton, ITransient { }