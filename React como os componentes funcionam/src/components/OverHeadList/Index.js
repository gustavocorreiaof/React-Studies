import './OverHeadList.css'
const OverHeadList = (props) => {
    return(
        <div className='overheadList'>
            <label>{props.Label}</label>
            <select onChange={evento => props.aoAlterado(evento.target.value)}>
                {props.itens.map(item => <option key={item }>{item}</option>)}
            </select>
        </div>
    )
}

export default OverHeadList