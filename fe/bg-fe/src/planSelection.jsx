import React, { useState, useEffect } from 'react';

const PlanSelectionComponent = () => {
  const [plans, setPlans] = useState([]);

  useEffect(() => {
    // Lógica para llamar al servicio de planes
  }, []);

  return (
    <div>
      <h2>Select a Plan</h2>
      <ul>
        {plans.map((plan) => (
          <li key={plan.codigo}>
            <img src={`path/to/images/${plan.icono}`} alt={plan.nombre} />
            <p>{plan.nombre}</p>
            <p>{plan.descripcion}</p>
            <p>{plan.valor}</p>
            {/* Otros detalles del plan */}
          </li>
        ))}
      </ul>
    </div>
  );
};

export default PlanSelectionComponent;
