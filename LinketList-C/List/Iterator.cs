using System;
using System.Collections.Generic;
using System.Text;

namespace LinketList_C.List
{
    public interface Iterator<T>
    {

        /**
         * Regresa el valor del nodo avctual y avanza al siguiente
         *
         * @return valor del nodo actual antes de avanzar al siguiente
         */
        T next();

        /**
         * Indica si se puede seguir iterando en la lista
         * @return true si se puede avanzar (se puede llamar a next()) o de lo contrario false
         *
         * @see Iterator::next
         */
        bool hasNext();

    }
}
