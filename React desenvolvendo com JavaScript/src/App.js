import Banner from './components/Banner/Banner';
import TextField from './components/TextField';

function App() {
  return (
    <div c lassName="App">
      <Banner></Banner>
      <TextField Label='Nome' PlaceHolder='Digite seu Nome'/>
      <TextField Label='Cargo' PlaceHolder='Digite seu cargo'/>
      <TextField Label='Imagem' PlaceHolder='Digite o endereço da imagem'/>
    </div>
  );
}

export default App;
