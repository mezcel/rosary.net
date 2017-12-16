-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema lecciodivina
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `lecciodivina` ;

-- -----------------------------------------------------
-- Schema lecciodivina
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `lecciodivina` DEFAULT CHARACTER SET utf8 ;
USE `lecciodivina` ;

-- -----------------------------------------------------
-- Table `lecciodivina`.`prayertype`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lecciodivina`.`prayertype` ;

CREATE TABLE IF NOT EXISTS `lecciodivina`.`prayertype` (
  `prayerTypeID` INT(11) NOT NULL,
  `prayerTypeName` MEDIUMTEXT NULL DEFAULT NULL,
  PRIMARY KEY (`prayerTypeID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `lecciodivina`.`mysterytype`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lecciodivina`.`mysterytype` ;

CREATE TABLE IF NOT EXISTS `lecciodivina`.`mysterytype` (
  `mysterytypeID` INT(11) NOT NULL,
  `mysterytypeName` VARCHAR(45) NULL DEFAULT NULL,
  `mysterytypeDescription` MEDIUMTEXT NULL DEFAULT NULL,
  PRIMARY KEY (`mysterytypeID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `lecciodivina`.`lexicon`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lecciodivina`.`lexicon` ;

CREATE TABLE IF NOT EXISTS `lecciodivina`.`lexicon` (
  `lexiconID` INT(11) NOT NULL,
  `lexiconName` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`lexiconID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `lecciodivina`.`beadtype`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lecciodivina`.`beadtype` ;

CREATE TABLE IF NOT EXISTS `lecciodivina`.`beadtype` (
  `beadTypeID` INT(11) NOT NULL,
  `beadTypeName` VARCHAR(45) NULL,
  `prayertype_FK` INT(11) NULL,
  `mysterytype_FK` INT(11) NULL,
  `lexicon_FK` INT(11) NULL,
  PRIMARY KEY (`beadTypeID`),
  INDEX `FK_beadtypeprayertype_idx` (`prayertype_FK` ASC),
  INDEX `FK_beadtypemysterytype_idx` (`mysterytype_FK` ASC),
  INDEX `FK_beadtypelexicon_idx` (`lexicon_FK` ASC),
  CONSTRAINT `FK_beadtypeprayertype`
    FOREIGN KEY (`prayertype_FK`)
    REFERENCES `lecciodivina`.`prayertype` (`prayerTypeID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_beadtypemysterytype`
    FOREIGN KEY (`mysterytype_FK`)
    REFERENCES `lecciodivina`.`mysterytype` (`mysterytypeID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_beadtypelexicon`
    FOREIGN KEY (`lexicon_FK`)
    REFERENCES `lecciodivina`.`lexicon` (`lexiconID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `lecciodivina`.`bible`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lecciodivina`.`bible` ;

CREATE TABLE IF NOT EXISTS `lecciodivina`.`bible` (
  `bibleID` INT(11) NOT NULL AUTO_INCREMENT,
  `bibleName` VARCHAR(45) NULL DEFAULT NULL,
  `bibleDescription` MEDIUMTEXT NULL DEFAULT NULL,
  `lexicon_FK` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`bibleID`),
  INDEX `FK_biblelexicon_idx` (`lexicon_FK` ASC),
  CONSTRAINT `FK_biblelexicon`
    FOREIGN KEY (`lexicon_FK`)
    REFERENCES `lecciodivina`.`lexicon` (`lexiconID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `lecciodivina`.`book`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lecciodivina`.`book` ;

CREATE TABLE IF NOT EXISTS `lecciodivina`.`book` (
  `bookID` INT(11) NOT NULL AUTO_INCREMENT,
  `bookName` VARCHAR(45) NULL DEFAULT NULL,
  `bookNumber` INT(11) NULL DEFAULT NULL,
  `bookDescription` MEDIUMTEXT NULL DEFAULT NULL,
  `bible_FK` INT(11) NULL DEFAULT NULL,
  `lexicon_FK` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`bookID`),
  INDEX `FK_bookbible_idx` (`bible_FK` ASC),
  INDEX `FK_booklexicon_idx` (`lexicon_FK` ASC),
  CONSTRAINT `FK_bookbible`
    FOREIGN KEY (`bible_FK`)
    REFERENCES `lecciodivina`.`bible` (`bibleID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_booklexicon`
    FOREIGN KEY (`lexicon_FK`)
    REFERENCES `lecciodivina`.`lexicon` (`lexiconID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `lecciodivina`.`chapter`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lecciodivina`.`chapter` ;

CREATE TABLE IF NOT EXISTS `lecciodivina`.`chapter` (
  `chapterID` INT(11) NOT NULL AUTO_INCREMENT,
  `chapterName` VARCHAR(45) NULL DEFAULT NULL,
  `chapterNumber` INT(11) NULL DEFAULT NULL,
  `chapterDescription` MEDIUMTEXT NULL DEFAULT NULL,
  `book_FK` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`chapterID`),
  INDEX `FK_chapterbook_idx` (`book_FK` ASC),
  CONSTRAINT `FK_chapterbook`
    FOREIGN KEY (`book_FK`)
    REFERENCES `lecciodivina`.`book` (`bookID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 8
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `lecciodivina`.`meditation`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lecciodivina`.`meditation` ;

CREATE TABLE IF NOT EXISTS `lecciodivina`.`meditation` (
  `meditationID` INT(11) NOT NULL,
  `meditationNumber` INT(11) NULL DEFAULT NULL,
  `meditationName` MEDIUMTEXT NULL DEFAULT NULL,
  `meditationDescription` LONGTEXT NULL DEFAULT NULL,
  `lexicon_FK` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`meditationID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `lecciodivina`.`mysterytext`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lecciodivina`.`mysterytext` ;

CREATE TABLE IF NOT EXISTS `lecciodivina`.`mysterytext` (
  `mysterytextID` INT(11) NOT NULL,
  `mystertextName` MEDIUMTEXT NULL DEFAULT NULL,
  `mysterytextDescription` MEDIUMTEXT NULL DEFAULT NULL,
  `mysteryType_FK` INT(11) NULL DEFAULT NULL,
  `lexicon_FK` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`mysterytextID`),
  INDEX `FK_mysterytextmysterytype_idx` (`mysteryType_FK` ASC),
  INDEX `FK_mysterytextlexicon_idx` (`lexicon_FK` ASC),
  CONSTRAINT `FK_mysterytextlexicon`
    FOREIGN KEY (`lexicon_FK`)
    REFERENCES `lecciodivina`.`lexicon` (`lexiconID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_mysterytextmysterytype`
    FOREIGN KEY (`mysteryType_FK`)
    REFERENCES `lecciodivina`.`mysterytype` (`mysterytypeID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `lecciodivina`.`prayertext`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lecciodivina`.`prayertext` ;

CREATE TABLE IF NOT EXISTS `lecciodivina`.`prayertext` (
  `prayertextID` INT(11) NOT NULL,
  `prayertextName` MEDIUMTEXT NULL DEFAULT NULL,
  `prayertextString` LONGTEXT NULL DEFAULT NULL,
  `prayerType_FK` INT(11) NULL DEFAULT NULL,
  `lexicon_FK` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`prayertextID`),
  INDEX `FK_prayertextprayertype_idx` (`prayerType_FK` ASC),
  INDEX `FK_prayertextlexicon_idx` (`lexicon_FK` ASC),
  CONSTRAINT `FK_prayertextlexicon`
    FOREIGN KEY (`lexicon_FK`)
    REFERENCES `lecciodivina`.`lexicon` (`lexiconID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_prayertextprayertype`
    FOREIGN KEY (`prayerType_FK`)
    REFERENCES `lecciodivina`.`prayertype` (`prayerTypeID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `lecciodivina`.`verse`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lecciodivina`.`verse` ;

CREATE TABLE IF NOT EXISTS `lecciodivina`.`verse` (
  `verseID` INT(11) NOT NULL,
  `verseNumber` INT(11) NULL DEFAULT NULL,
  `verseString` MEDIUMTEXT NULL DEFAULT NULL,
  `chapter_FK` INT(11) NULL DEFAULT NULL,
  `book_FK` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`verseID`),
  INDEX `FK_versechapter_idx` (`chapter_FK` ASC),
  INDEX `FK_versebook_idx` (`book_FK` ASC),
  CONSTRAINT `FK_versebook`
    FOREIGN KEY (`book_FK`)
    REFERENCES `lecciodivina`.`book` (`bookID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_versechapter`
    FOREIGN KEY (`chapter_FK`)
    REFERENCES `lecciodivina`.`chapter` (`chapterID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `lecciodivina`.`bead`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lecciodivina`.`bead` ;

CREATE TABLE IF NOT EXISTS `lecciodivina`.`bead` (
  `beadID` INT(11) NOT NULL,
  `beadNumber` INT NULL,
  `beadtype_FK` INT(11) NULL,
  `meditation_FK` INT(11) NULL,
  `verse_FK` INT(11) NULL,
  PRIMARY KEY (`beadID`),
  INDEX `FK_beadbeadtype_idx` (`beadtype_FK` ASC),
  INDEX `FK_beadmeditation_idx` (`meditation_FK` ASC),
  INDEX `FK_beadverse_idx` (`verse_FK` ASC),
  CONSTRAINT `FK_beadbeadtype`
    FOREIGN KEY (`beadtype_FK`)
    REFERENCES `lecciodivina`.`beadtype` (`beadTypeID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_beadmeditation`
    FOREIGN KEY (`meditation_FK`)
    REFERENCES `lecciodivina`.`meditation` (`meditationID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_beadverse`
    FOREIGN KEY (`verse_FK`)
    REFERENCES `lecciodivina`.`verse` (`verseID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
