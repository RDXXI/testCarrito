
const apiUrl = 'https://localhost:7274/api';


export const fetchData = async (endpoint) => {
  try {
    const response = await fetch(`${apiUrl}/${endpoint}`);
    if (!response.ok) {
      throw new Error('Error al obtener datos');
    }

    const data = await response.json();
    return data;
  } catch (error) {
    console.error('Error de red:', error);
    throw error; 
  }
};
