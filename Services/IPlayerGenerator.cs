using DependencyInjectionDemo.Models;
using System;

namespace DependencyInjectionDemo.Services
{
    public interface IPlayerGenerator
    {
        Player CreateNewPlayer();
    }
}