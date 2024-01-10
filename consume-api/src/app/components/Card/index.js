import Styles from './Card.module.css';

export default async function Card() {

    const cards = await fetch('http://localhost:5164/api/Destinos', {
        method: 'GET',
        headers: {
            'Cache-Control': 'no-cache',
            'Pragma': 'no-cache',
        },
    }).then(res => res.json());


    return (

        <div className={Styles.container}>
            {cards?.map((card) => (
                <div key={card.idDes} className={Styles.card}>
                    <img src={card.imgDestino} alt={card.title} />
                    <div className={Styles.card_title}>
                        <p>{card.nomeDes}</p>
                    </div>
                </div>
            ))}
        </div>
    )


}
