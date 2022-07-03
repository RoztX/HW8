using HW8;
using Autofac;

var config = new Config();
var conteiner = config.RegistrarDependency();
var starter = conteiner.Resolve<Starter>();
starter.Start();