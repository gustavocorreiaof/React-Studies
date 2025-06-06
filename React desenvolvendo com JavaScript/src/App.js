import { useState } from 'react';
import Banner from './components/Banner/Banner';
import Form from './components/Form';
import TextField from './components/TextField';

function App() {
  
  const [colaboradores, setColaboradores] = useState([])

  const aoNovoColaboradorAdicionado = (colaborador) => {
    console.log(colaborador)
    setColaboradores([...colaboradores, colaborador])
    console.log(colaboradores)
  }
  
  return (
    <div className="App">
      <Banner></Banner>
      <Form aoColaboradorCadastrado={colaborador => aoNovoColaboradorAdicionado(colaborador)}></Form>   
       
    </div>
  );
}

export default App;
