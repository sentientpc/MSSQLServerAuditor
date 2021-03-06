﻿<?xml version="1.0" encoding="UTF-8"?>
<root>
	<mssqlauditorpreprocessors name="Таблицы с ненадёжными внешними ключами" id="TablesWithForeignKeysNotTrusted.Description.HTML.ru" columns="100" rows="100" splitter="yes">
		<mssqlauditorpreprocessor preprocessor="HtmlPreprocessorDialog" name="Таблицы с ненадёжными внешними ключами" id="TablesWithForeignKeysNotTrusted.Description.HTML.ru" column="1" row="1" colspan="1" rowspan="1">
			<xsl:stylesheet version="1.0"
					xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
					xmlns:ms="urn:schemas-microsoft-com:xslt"
					xmlns:dt="urn:schemas-microsoft-com:datatypes">

			<xsl:template match="/">

			<html>
			<head>
			</head>
			<body>
			<h1 class="firstHeading">Таблицы с ненадёжными внешними ключами</h1>

				<p>Достаточно распространённой практикой при загрузе большого объёма данных
				считается выключение внешних ключей (Foreign Keys), что действительно
				приводик улучшению производительности при загрузке. Но после загрузки
				данных, нужно не только включить внешние ключи, но и проверить корректность
				данных. Если этого не сделать, но внешние ключи будут считаться ненадёжными
				и не будут использоваться оптимизатором при запросах.</p>

				<p>Приведенный отчёт найдет все подобные внешние ключи, и остаётся только
				выполнить проверку для упомянутых таблиц.</p>

				<p><strong>Как это исправить:</strong> Для всех таблиц выполните операцию
				alter table ИМЯ_ТАБЛИЦЫ with check check constraint ИМЯ_КЛЮЧА.</p>

				<p><strong>Уровень сложности:</strong> Средний</p>

				<p><strong>Уровень опасности:</strong> Низкий</p>

				<p><a href="http://www.f1incode.com/2011/10/foreign-key-enable-and-disable.html" target="_blank">Правильное включение и проверка внешних ключей (foreign key)</a></p>

				<p><a href="http://www.brentozar.com/blitz/foreign-key-trusted/" target="_blank">Blitz Result: Foreign Keys or Check Constraints Not Trusted</a></p>

			</body>
			</html>
			</xsl:template>
			</xsl:stylesheet>
		</mssqlauditorpreprocessor>
	</mssqlauditorpreprocessors>
</root>

