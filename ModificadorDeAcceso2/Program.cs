using System;

namespace AccessModifiersExample
{
    /**
     * 
     * Explicación:
     * 
        - protected internal class:

        En DerivedClass, puedes acceder a ProtectedInternalClass porque es una clase derivada y está en el mismo ensamblado.
        En AnotherClassInSameAssembly, puedes acceder a ProtectedInternalClass porque está en el mismo ensamblado.
        En DerivedFromAnotherAssembly, puedes acceder a ProtectedInternalClass porque es una clase derivada de BaseClass.
        
        - private protected class:

        En DerivedClass, puedes acceder a PrivateProtectedClass porque está en el mismo ensamblado y es una clase derivada.
        No puedes acceder a PrivateProtectedClass desde AnotherClassInSameAssembly ni desde DerivedFromAnotherAssembly, ya que no son clases derivadas y PrivateProtectedClass no es accesible desde fuera de su ensamblado.
     * 
     */

    // Clase base
    public class BaseClass
    {
        // Miembro con protected internal: accesible en el mismo ensamblado o clases derivadas en otros ensamblados
        protected internal class ProtectedInternalClass
        {
            public void ShowMessage()
            {
                Console.WriteLine("Hello from ProtectedInternalClass!");
            }
        }

        // Miembro con private protected: accesible solo en el mismo ensamblado y en clases derivadas
        private protected class PrivateProtectedClass
        {
            public void ShowMessage()
            {
                Console.WriteLine("Hello from PrivateProtectedClass!");
            }
        }
    }

    // Clase derivada en el mismo ensamblado
    public class DerivedClass : BaseClass
    {
        public void AccessClasses()
        {
            // Puede acceder a 'ProtectedInternalClass'
            var internalClass = new ProtectedInternalClass();
            internalClass.ShowMessage();

            // Puede acceder a 'PrivateProtectedClass'
            var privateProtectedClass = new PrivateProtectedClass();
            privateProtectedClass.ShowMessage();
        }
    }

    // Clase en el mismo ensamblado
    public class AnotherClassInSameAssembly
    {
        public void AccessClasses(BaseClass baseClass)
        {
            // Puede acceder a 'ProtectedInternalClass'
            var internalClass = new BaseClass.ProtectedInternalClass();
            internalClass.ShowMessage();

            // No puede acceder a 'PrivateProtectedClass'
            // var privateProtectedClass = new BaseClass.PrivateProtectedClass(); // Error: No es accesible
        }
    }

    // Simulación de acceso desde otro ensamblado
    namespace AnotherAssembly
    {
        // Clase derivada en otro ensamblado (simulado)
        public class DerivedFromAnotherAssembly : BaseClass
        {
            public void AccessClasses()
            {
                // Puede acceder a 'ProtectedInternalClass'
                var internalClass = new ProtectedInternalClass();
                internalClass.ShowMessage();

                // No puede acceder a 'PrivateProtectedClass'
                // var privateProtectedClass = new PrivateProtectedClass(); // Error: No es accesible
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.AccessClasses();

            Console.WriteLine("\nFrom AnotherClassInSameAssembly:");
            AnotherClassInSameAssembly anotherClass = new AnotherClassInSameAssembly();
            anotherClass.AccessClasses(new BaseClass());

            Console.WriteLine("\nFrom DerivedFromAnotherAssembly:");
            AnotherAssembly.DerivedFromAnotherAssembly anotherDerived = new AnotherAssembly.DerivedFromAnotherAssembly();
            anotherDerived.AccessClasses();
        }
    }
}
