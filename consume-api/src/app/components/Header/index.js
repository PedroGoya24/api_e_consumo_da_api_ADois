import Link from 'next/link'

export default function Header() {
	return (
		<header className="header">
			<img src="/Logo2.png" alt="logo" className='logo'/>
			<ul>
				<li>
					<Link href="/RotaUm">Home</Link>
				</li>
				<li>
					<Link href="/RotaDois">Destinos</Link>
				</li>
			</ul>
		</header>
	)
}