import React, { useEffect,useState } from 'react';
import { fetchData } from './api';

const LoginComponent = () => {
    // const [data, setData] = useState(null);
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [data, setData] = useState(null);

  const handleLogin = async () => {
    try {
        const result = await fetchData('usuario'); // Reemplaza 'tu-endpoint' con el endpoint específico
        setData(result);
      } catch (error) {
      }
  };
  useEffect(() => {
  const handleLogin = async () => {
    try {
        const result = await fetchData('usuario'); // Reemplaza 'tu-endpoint' con el endpoint específico
        setData(result);
      } catch (error) {
      }
  };
  handleLogin();
}, []);
  

  return (
    <div>
      <h2>Login</h2>
      <input type="text" placeholder="Email" value={email} onChange={(e) => setEmail(e.target.value)} />
      <input type="password" placeholder="Password" value={password} onChange={(e) => setPassword(e.target.value)} />
      <button onClick={handleLogin}>Login</button>

      <div>
      {data ? (
        <div>
          <h1>{data.title}</h1>
        </div>
      ) : (
        <p>Cargando datos...</p>
      )}
    </div>

    </div>




  );
};

export default LoginComponent;
