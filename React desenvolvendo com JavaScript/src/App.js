import Banner from './components/Banner/Banner';
import TextField from './components/TextField';

function App() {
  return (
    <div c lassName="App">
      <Banner></Banner>
      <TextField Nome='Nome' PlaceHolder='Digite seu Nome'/>
      <TextField Nome='Cargo' PlaceHolder='Digite seu cargo'/>
      <TextField Nome='Imagem' PlaceHolder='Digite o endereço da imagem'/>
    </div>
  );
}

export default App;
