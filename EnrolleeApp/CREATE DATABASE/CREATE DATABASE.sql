-- MySQL Script generated by MySQL Workbench
-- 06/22/17 07:54:25
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema enrolleeDB
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema enrolleeDB
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `enrolleeDB` DEFAULT CHARACTER SET utf8 ;
USE `enrolleeDB` ;

-- -----------------------------------------------------
-- Table `enrolleeDB`.`Polity`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `enrolleeDB`.`Polity` (
  `Pol_id` MEDIUMINT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Идентификатор записи названия государства',
  `Pol_title` VARCHAR(40) NOT NULL COMMENT 'Название государства',
  PRIMARY KEY (`Pol_id`),
  UNIQUE INDEX `Pol_title_UNIQUE` (`Pol_title` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `enrolleeDB`.`Lang`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `enrolleeDB`.`Lang` (
  `L_id` MEDIUMINT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Идентификатор записи названия иностранного языка',
  `L_title` VARCHAR(40) NOT NULL COMMENT 'Название иностранного языка',
  PRIMARY KEY (`L_id`),
  UNIQUE INDEX `L_title_UNIQUE` (`L_title` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `enrolleeDB`.`Base`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `enrolleeDB`.`Base` (
  `B_id` MEDIUMINT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Идентификатор записи названия базы образования',
  `B_title` VARCHAR(80) NOT NULL COMMENT 'Название базы образования',
  PRIMARY KEY (`B_id`),
  UNIQUE INDEX `B_title_UNIQUE` (`B_title` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `enrolleeDB`.`Discipline`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `enrolleeDB`.`Discipline` (
  `D_id` MEDIUMINT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Идентификатор записи с названием дисциплины',
  `D_title` VARCHAR(40) NOT NULL COMMENT 'Название дисциплины',
  PRIMARY KEY (`D_id`),
  UNIQUE INDEX `D_title_UNIQUE` (`D_title` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `enrolleeDB`.`Spec`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `enrolleeDB`.`Spec` (
  `S_id` TINYINT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Идентификатор записи о специальности',
  `S_shifr` VARCHAR(10) NOT NULL COMMENT 'Шифр специальности',
  `S_spec` VARCHAR(45) NOT NULL COMMENT 'Название квалификации по специальности',
  `S_title` VARCHAR(100) NOT NULL COMMENT 'Название специальности',
  `S_short` VARCHAR(6) NOT NULL COMMENT 'Аббревиатура специальности',
  `S_ochn` TINYINT(1) NOT NULL COMMENT 'Форма обучения на специальности',
  `S_budjet` TINYINT(1) NOT NULL COMMENT 'Основа обучения на специальности',
  `S_discipline1` MEDIUMINT UNSIGNED NULL COMMENT 'Код первой ведущей дисциплины, важной в принятии решения о зачислении абитуриентов на специальность (внешний ключ)',
  `S_discipline2` MEDIUMINT UNSIGNED NULL COMMENT 'Код второй ведущей дисциплины, важной в принятии решения о зачислении абитуриентов на специальность (внешний ключ)',
  `S_discipline3` MEDIUMINT UNSIGNED NULL COMMENT 'Код третьей ведущей дисциплины, важной в принятии решения о зачислении абитуриентов на специальность (внешний ключ)',
  PRIMARY KEY (`S_id`),
  INDEX `DisciplineToSpec_idx` (`S_discipline1` ASC),
  INDEX `DisciplineToSpec2_idx` (`S_discipline2` ASC),
  INDEX `DisciplineToSpec3_idx` (`S_discipline3` ASC),
  CONSTRAINT `DisciplineToSpec1`
    FOREIGN KEY (`S_discipline1`)
    REFERENCES `enrolleeDB`.`Discipline` (`D_id`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION,
  CONSTRAINT `DisciplineToSpec2`
    FOREIGN KEY (`S_discipline2`)
    REFERENCES `enrolleeDB`.`Discipline` (`D_id`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION,
  CONSTRAINT `DisciplineToSpec3`
    FOREIGN KEY (`S_discipline3`)
    REFERENCES `enrolleeDB`.`Discipline` (`D_id`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `enrolleeDB`.`Groups`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `enrolleeDB`.`Groups` (
  `gr_id` MEDIUMINT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Идентификатор группы',
  `gr_name` VARCHAR(20) NOT NULL COMMENT 'Наименование группы',
  `gr_spec` TINYINT UNSIGNED NULL COMMENT 'Код специальности, по которой производится обучение (внешний ключ)',
  `gr_year` VARCHAR(4) NOT NULL COMMENT 'Год начала обучения',
  `gr_students` TINYINT UNSIGNED NULL COMMENT 'Контрольные цифры приема на обучение по специальности',
  PRIMARY KEY (`gr_id`),
  INDEX `SpecToGroups_idx` (`gr_spec` ASC),
  CONSTRAINT `SpecToGroups`
    FOREIGN KEY (`gr_spec`)
    REFERENCES `enrolleeDB`.`Spec` (`S_id`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `enrolleeDB`.`Abit`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `enrolleeDB`.`Abit` (
  `id` MEDIUMINT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Идентификатор записи об абитуриенте',
  `Reg` VARCHAR(10) NOT NULL COMMENT 'Регистрационный номер',
  `FIO` VARCHAR(50) NOT NULL COMMENT 'Ф.И.О. абитуриента',
  `Gender` VARCHAR(10) NOT NULL COMMENT 'Пол абитуриента',
  `BirthDate` DATE NOT NULL COMMENT 'Дата рождения абитуриента',
  `BirthPlace` VARCHAR(50) NOT NULL COMMENT 'Место рождения абитуриента',
  `Polity` MEDIUMINT UNSIGNED NULL COMMENT 'Код названия государства, являющегося гражданством абитуриента (внешний ключ)',
  `Pasp` VARCHAR(100) NOT NULL COMMENT 'Данные о паспорте абитуриента (серия, номер, кем и когда выдан)',
  `AdrReg` VARCHAR(80) NOT NULL COMMENT 'Адрес регистрации абитуриента',
  `AdrFact` VARCHAR(80) NOT NULL COMMENT 'Адрес проживания абитуриента',
  `Phone` VARCHAR(20) NOT NULL COMMENT 'Номер телефона абитуриента',
  `Midball` FLOAT NOT NULL COMMENT 'Средний балл документа об образовании абитуриента',
  `Lang` MEDIUMINT UNSIGNED NULL COMMENT 'Код иностранного языка, изученного абитуриентом (внешний ключ)',
  `NeedHostel` TINYINT(1) NOT NULL COMMENT 'Необходимость в предоставление места в общежитии',
  `Prior1` TINYINT UNSIGNED NULL COMMENT 'Код выбранной абитуриентом специальности, занимающей первое место в приоритетах абитуриента на специальность (внешний ключ)',
  `Prior2` TINYINT UNSIGNED NULL COMMENT 'Код выбранной абитуриентом специальности, занимающей второе место в приоритетах абитуриента на специальность (внешний ключ)',
  `Prior3` TINYINT UNSIGNED NULL COMMENT 'Код выбранной абитуриентом специальности, занимающей третье место в приоритетах абитуриента на специальность (внешний ключ)',
  `Group_enroll` MEDIUMINT UNSIGNED NULL COMMENT 'Код группы, принятие решения о зачислении в которую рассматривается (внешний ключ)',
  `DocBack` DATE NULL COMMENT 'Дата выдачи документов абитуриенту',
  `Date` DATE NULL COMMENT 'Дата подачи заявления',
  `E_base` MEDIUMINT UNSIGNED NULL COMMENT 'Код базы образования, оконченного абитуриентом (внешний ключ)',
  `E_title` VARCHAR(100) NOT NULL COMMENT 'Наименование оконченного абитуриентом образовательного учреждения',
  `E_yend` VARCHAR(4) NOT NULL COMMENT 'Год окончания абитуриентом образовательного учреждения',
  `E_doctype` VARCHAR(20) NOT NULL COMMENT 'Тип документа об образовании',
  `E_docsernum` VARCHAR(20) NOT NULL COMMENT 'Серия и номер предоставленного абитуриентом документа об образовании',
  `E_docdate` DATE NOT NULL COMMENT 'Дата выдачи предоставленного абитуриентом документа об образовании',
  `Discipline1` TINYINT NULL COMMENT 'Оценка по первому предмету из предоставленного абитуриентом документа об образовании',
  `Discipline2` TINYINT NULL COMMENT 'Оценка по второму предмету из предоставленного абитуриентом документа об образовании',
  `Discipline3` TINYINT NULL COMMENT 'Оценка по третьему предмету из предоставленного абитуриентом документа об образовании',
  `Medpolis` VARCHAR(16) NOT NULL COMMENT 'Предоставленный абитуриентом медицинский полис',
  `S_orphan` TINYINT(1) NOT NULL DEFAULT 0 COMMENT 'Наличие статуса сироты',
  `S_invalid` TINYINT(1) NOT NULL DEFAULT 0 COMMENT 'Наличие статуса инвалида',
  `S_objective` TINYINT(1) NOT NULL DEFAULT 0 COMMENT 'Наличие целевого контракта',
  `S_contract` TINYINT(1) NOT NULL DEFAULT 0 COMMENT 'Наличие договора на обучение на платной основе',
  PRIMARY KEY (`id`),
  INDEX `Polity_idx` (`Polity` ASC),
  INDEX `LangToAbit_idx` (`Lang` ASC),
  INDEX `BaseToAbit_idx` (`E_base` ASC),
  INDEX `SpecToAbit_idx` (`Prior1` ASC),
  INDEX `SpecToAbit2_idx` (`Prior2` ASC),
  INDEX `SpecToAbit3_idx` (`Prior3` ASC),
  UNIQUE INDEX `Reg_UNIQUE` (`Reg` ASC),
  INDEX `GroupsToAbit_idx` (`Group_enroll` ASC),
  CONSTRAINT `PolityToAbit`
    FOREIGN KEY (`Polity`)
    REFERENCES `enrolleeDB`.`Polity` (`Pol_id`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION,
  CONSTRAINT `LangToAbit`
    FOREIGN KEY (`Lang`)
    REFERENCES `enrolleeDB`.`Lang` (`L_id`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION,
  CONSTRAINT `BaseToAbit`
    FOREIGN KEY (`E_base`)
    REFERENCES `enrolleeDB`.`Base` (`B_id`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION,
  CONSTRAINT `SpecToAbit1`
    FOREIGN KEY (`Prior1`)
    REFERENCES `enrolleeDB`.`Spec` (`S_id`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION,
  CONSTRAINT `SpecToAbit2`
    FOREIGN KEY (`Prior2`)
    REFERENCES `enrolleeDB`.`Spec` (`S_id`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION,
  CONSTRAINT `SpecToAbit3`
    FOREIGN KEY (`Prior3`)
    REFERENCES `enrolleeDB`.`Spec` (`S_id`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION,
  CONSTRAINT `GroupsToAbit`
    FOREIGN KEY (`Group_enroll`)
    REFERENCES `enrolleeDB`.`Groups` (`gr_id`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `enrolleeDB`.`Parent`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `enrolleeDB`.`Parent` (
  `P_id` MEDIUMINT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Идентификатор записи о родителе',
  `P_abit` MEDIUMINT UNSIGNED NOT NULL COMMENT 'Код абитуриента, родителем которого является записываемый родитель (внешний ключ)',
  `P_FIO` VARCHAR(50) NOT NULL COMMENT 'Ф.И.О. родителя',
  `P_adrreg` VARCHAR(80) NOT NULL COMMENT 'Адрес регистрации родителя',
  `P_adrfact` VARCHAR(80) NOT NULL COMMENT 'Адрес проживания родителя',
  `P_workpost` VARCHAR(80) NOT NULL COMMENT 'Место работы и занимаимая должность родителя, если есть',
  `P_phone` VARCHAR(20) NOT NULL COMMENT 'Номер телефона родителя',
  PRIMARY KEY (`P_id`),
  INDEX `AbitToParent_idx` (`P_abit` ASC),
  CONSTRAINT `AbitToParent`
    FOREIGN KEY (`P_abit`)
    REFERENCES `enrolleeDB`.`Abit` (`id`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `enrolleeDB`.`Status`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `enrolleeDB`.`Status` (
  `St_id` MEDIUMINT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Идентификатор записи о документе, подтверждающем статус абитуриента',
  `St_abit` MEDIUMINT UNSIGNED NOT NULL COMMENT 'Код абитуриента, предоставляющего записываемый документ, подтверждаемый статус (внешний ключ)',
  `St_type` VARCHAR(20) NOT NULL COMMENT 'Тип статуса, подтверждаемый предоставленным абитуриентом документом',
  `St_docinform` VARCHAR(100) NOT NULL COMMENT 'Информация из предоставленного абитуриентом документа, подтверждающего статус',
  PRIMARY KEY (`St_id`),
  INDEX `AbitToStatus_idx` (`St_abit` ASC),
  CONSTRAINT `AbitToStatus`
    FOREIGN KEY (`St_abit`)
    REFERENCES `enrolleeDB`.`Abit` (`id`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `enrolleeDB`.`Military`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `enrolleeDB`.`Military` (
  `M_id` MEDIUMINT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Идентификатор записи о документе, подтверждающем воинскую обязанность абитуриента',
  `M_abit` MEDIUMINT UNSIGNED NOT NULL COMMENT 'Код абитуриента, предоставляющего записываемый документ, подтверждаемый воинскую обязанность (внешний ключ)',
  `M_type` VARCHAR(40) NOT NULL COMMENT 'Тип документа, подтверждающего воинскую обязанность абитуриента',
  `M_docinform` VARCHAR(80) NOT NULL COMMENT 'Информация из предоставленного абитуриентом документа, подтверждаемого воинскую обязанность',
  PRIMARY KEY (`M_id`),
  INDEX `AbitToMilitary_idx` (`M_abit` ASC),
  CONSTRAINT `AbitToMilitary`
    FOREIGN KEY (`M_abit`)
    REFERENCES `enrolleeDB`.`Abit` (`id`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `enrolleeDB`.`Komis`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `enrolleeDB`.`Komis` (
  `K_id` MEDIUMINT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Идентификатор записи о члене комиссии',
  `K_FIO` VARCHAR(50) NOT NULL COMMENT 'Ф.И.О. члена комиссии',
  PRIMARY KEY (`K_id`),
  UNIQUE INDEX `K_FIO_UNIQUE` (`K_FIO` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `enrolleeDB`.`Log`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `enrolleeDB`.`Log` (
  `Log_id` BIGINT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Идентификатор записи',
  `Log_datime` DATETIME NOT NULL COMMENT 'Дата и время выполнения процедуры или операции',
  `Log_event` VARCHAR(30) NOT NULL COMMENT 'Описание процедуры или операции',
  `Log_desc` VARCHAR(100) NOT NULL COMMENT 'Описание результата выполненной процедуры или операции',
  PRIMARY KEY (`Log_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `enrolleeDB`.`Decision`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `enrolleeDB`.`Decision` (
  `Des_id` MEDIUMINT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Идентификатор решения комиссии',
  `Des_abit` MEDIUMINT UNSIGNED NULL COMMENT 'Идентификатор записи об абитуриенте (внешний ключ)',
  `Des_group` MEDIUMINT UNSIGNED NULL COMMENT 'Код группы, в которую производится зачисление',
  `Des_resolution` VARCHAR(20) NOT NULL COMMENT 'Решение комиссии о зачислении абитуриента',
  `Comment` VARCHAR(100) NOT NULL COMMENT 'Комментарий к решению комиссии',
  `Des_date` DATE NOT NULL COMMENT 'Дата принятия решения',
  `Des_komis` MEDIUMINT UNSIGNED NULL COMMENT 'Идентификатор записи об члене комиссии',
  PRIMARY KEY (`Des_id`),
  INDEX `KomisToDecision_idx` (`Des_komis` ASC),
  INDEX `DecisionoAbit_idx` (`Des_abit` ASC),
  INDEX `GroupsToDecision_idx` (`Des_group` ASC),
  CONSTRAINT `KomisToDecision`
    FOREIGN KEY (`Des_komis`)
    REFERENCES `enrolleeDB`.`Komis` (`K_id`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION,
  CONSTRAINT `AbitToDecision`
    FOREIGN KEY (`Des_abit`)
    REFERENCES `enrolleeDB`.`Abit` (`id`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION,
  CONSTRAINT `GroupsToDecision`
    FOREIGN KEY (`Des_group`)
    REFERENCES `enrolleeDB`.`Groups` (`gr_id`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
