-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`addresses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`addresses` (
  `address_id` INT NOT NULL,
  `city` VARCHAR(58) NOT NULL,
  `postal_code` VARCHAR(12) NOT NULL,
  `street` VARCHAR(35) NOT NULL,
  `house_number` INT NOT NULL,
  PRIMARY KEY (`address_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`contacts`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`contacts` (
  `contact_id` INT NOT NULL,
  `first_name` VARCHAR(35) NOT NULL,
  `last_name` VARCHAR(35) NOT NULL,
  `birth_date` DATE NOT NULL,
  `phone_number` VARCHAR(15) NOT NULL,
  `address_address_id` INT NOT NULL,
  PRIMARY KEY (`contact_id`),
  INDEX `fk_contact_address1_idx` (`address_address_id` ASC) VISIBLE,
  CONSTRAINT `fk_contact_address1`
    FOREIGN KEY (`address_address_id`)
    REFERENCES `mydb`.`addresses` (`address_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`clients`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`clients` (
  `client_id` INT NOT NULL,
  `registration_date` DATE NOT NULL,
  `contact_id` INT NOT NULL,
  PRIMARY KEY (`client_id`),
  UNIQUE INDEX `client_id_UNIQUE` (`client_id` ASC) VISIBLE,
  INDEX `fk_client_contact1_idx` (`contact_id` ASC) VISIBLE,
  CONSTRAINT `fk_client_contact1`
    FOREIGN KEY (`contact_id`)
    REFERENCES `mydb`.`contacts` (`contact_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`client_accounts`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`client_accounts` (
  `client_id` INT NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `login` VARCHAR(100) NOT NULL,
  `password` VARCHAR(72) NOT NULL,
  PRIMARY KEY (`client_id`),
  INDEX `fk_client_account_client1_idx` (`client_id` ASC) VISIBLE,
  CONSTRAINT `fk_client_account_client1`
    FOREIGN KEY (`client_id`)
    REFERENCES `mydb`.`clients` (`client_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`specialties`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`specialties` (
  `specialty_id` INT NOT NULL,
  `name` VARCHAR(45) NOT NULL,
  `description` VARCHAR(800) NOT NULL,
  PRIMARY KEY (`specialty_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`shift_types`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`shift_types` (
  `shift_type_id` INT NOT NULL,
  `start_time` TIME NOT NULL,
  `end_time` TIME NOT NULL,
  PRIMARY KEY (`shift_type_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`doctors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`doctors` (
  `doctor_id` INT NOT NULL,
  `contact_id` INT NOT NULL,
  `shift_type` INT NOT NULL,
  `cabinet` VARCHAR(6) NOT NULL,
  PRIMARY KEY (`doctor_id`),
  INDEX `fk_doctor_contact1_idx` (`contact_id` ASC) VISIBLE,
  INDEX `fk_doctor_shift_types1_idx` (`shift_type` ASC) VISIBLE,
  CONSTRAINT `fk_doctor_contact1`
    FOREIGN KEY (`contact_id`)
    REFERENCES `mydb`.`contacts` (`contact_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_doctor_shift_types1`
    FOREIGN KEY (`shift_type`)
    REFERENCES `mydb`.`shift_types` (`shift_type_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`leave_reasons`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`leave_reasons` (
  `reason_id` INT NOT NULL,
  `reason_name` VARCHAR(45) NOT NULL,
  `reason_description` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`reason_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`leaves`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`leaves` (
  `leave_id` INT NOT NULL,
  `doctor_id` INT NOT NULL,
  `leave_reason` INT NOT NULL,
  `start_date` DATE NOT NULL,
  `end_date` DATE NOT NULL,
  PRIMARY KEY (`leave_id`),
  INDEX `fk_leaves_leave_reasons1_idx` (`leave_reason` ASC) VISIBLE,
  INDEX `fk_leaves_doctor1_idx` (`doctor_id` ASC) VISIBLE,
  CONSTRAINT `fk_leaves_leave_reasons1`
    FOREIGN KEY (`leave_reason`)
    REFERENCES `mydb`.`leave_reasons` (`reason_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_leaves_doctor1`
    FOREIGN KEY (`doctor_id`)
    REFERENCES `mydb`.`doctors` (`doctor_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`promocodes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`promocodes` (
  `promocode_id` VARCHAR(16) NOT NULL,
  `sale_percentage` INT NOT NULL,
  `is_redeemed` TINYINT(1) NOT NULL,
  PRIMARY KEY (`promocode_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`benefits`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`benefits` (
  `benefit_id` INT NOT NULL,
  `benefit_name` VARCHAR(45) NOT NULL,
  `description` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`benefit_id`),
  UNIQUE INDEX `benefit_name_UNIQUE` (`benefit_name` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`clients_and_benefits`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`clients_and_benefits` (
  `benefit_id` INT NOT NULL,
  `client_id` INT NOT NULL,
  `start_date` DATE NOT NULL,
  `end_date` DATE NOT NULL,
  PRIMARY KEY (`benefit_id`, `client_id`),
  INDEX `fk_benefits_has_client_client1_idx` (`client_id` ASC) VISIBLE,
  INDEX `fk_benefits_has_client_benefits_idx` (`benefit_id` ASC) VISIBLE,
  CONSTRAINT `fk_benefits_has_client_benefits`
    FOREIGN KEY (`benefit_id`)
    REFERENCES `mydb`.`benefits` (`benefit_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_benefits_has_client_client1`
    FOREIGN KEY (`client_id`)
    REFERENCES `mydb`.`clients` (`client_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`doctors_specialties`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`doctors_specialties` (
  `doctor_id` INT NOT NULL,
  `specialty_id` INT NOT NULL,
  PRIMARY KEY (`doctor_id`, `specialty_id`),
  INDEX `fk_specialties_has_doctor_doctor1_idx` (`specialty_id` ASC) VISIBLE,
  INDEX `fk_specialties_has_doctor_specialties1_idx` (`doctor_id` ASC) VISIBLE,
  CONSTRAINT `fk_specialties_has_doctor_specialties1`
    FOREIGN KEY (`doctor_id`)
    REFERENCES `mydb`.`specialties` (`specialty_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_specialties_has_doctor_doctor1`
    FOREIGN KEY (`specialty_id`)
    REFERENCES `mydb`.`doctors` (`doctor_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`visits`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`visits` (
  `visit_id` INT NOT NULL,
  `doctor_id` INT NOT NULL,
  `client_id` INT NOT NULL,
  `datetime` DATETIME NOT NULL,
  `total_price` INT NOT NULL,
  `description` VARCHAR(1000) NULL,
  INDEX `fk_doctor_has_client_client1_idx` (`client_id` ASC) VISIBLE,
  INDEX `fk_doctor_has_client_doctor1_idx` (`doctor_id` ASC) VISIBLE,
  PRIMARY KEY (`visit_id`),
  CONSTRAINT `fk_doctor_has_client_doctor1`
    FOREIGN KEY (`doctor_id`)
    REFERENCES `mydb`.`doctors` (`doctor_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_doctor_has_client_client1`
    FOREIGN KEY (`client_id`)
    REFERENCES `mydb`.`clients` (`client_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`treatments`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`treatments` (
  `treatment_id` INT NOT NULL,
  `specialty_id` INT NULL,
  `name` VARCHAR(100) NOT NULL,
  `description` VARCHAR(600) NOT NULL,
  `duration` INT NOT NULL,
  PRIMARY KEY (`treatment_id`),
  INDEX `fk_treatments_specialties1_idx` (`specialty_id` ASC) VISIBLE,
  CONSTRAINT `fk_treatments_specialties1`
    FOREIGN KEY (`specialty_id`)
    REFERENCES `mydb`.`specialties` (`specialty_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`treatments_has_visits`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`treatments_has_visits` (
  `visit_id` INT NOT NULL,
  `treatment_id` INT NOT NULL,
  PRIMARY KEY (`visit_id`, `treatment_id`),
  INDEX `fk_treatments_has_visits_visits1_idx` (`visit_id` ASC) VISIBLE,
  INDEX `fk_treatments_has_visits_treatments1_idx` (`treatment_id` ASC) VISIBLE,
  CONSTRAINT `fk_treatments_has_visits_treatments1`
    FOREIGN KEY (`treatment_id`)
    REFERENCES `mydb`.`treatments` (`treatment_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_treatments_has_visits_visits1`
    FOREIGN KEY (`visit_id`)
    REFERENCES `mydb`.`visits` (`visit_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`doctor_accounts`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`doctor_accounts` (
  `doctor_id` INT NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `login` VARCHAR(100) NOT NULL,
  `password` VARCHAR(72) NOT NULL,
  PRIMARY KEY (`doctor_id`),
  INDEX `fk_doctor_accounts_doctors1_idx` (`doctor_id` ASC) VISIBLE,
  CONSTRAINT `fk_doctor_accounts_doctors1`
    FOREIGN KEY (`doctor_id`)
    REFERENCES `mydb`.`doctors` (`doctor_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`diagnoses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`diagnoses` (
  `diagnosis_id` INT NOT NULL,
  `name` VARCHAR(95) NOT NULL,
  PRIMARY KEY (`diagnosis_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`visits_has_diagnoses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`visits_has_diagnoses` (
  `visit_id` INT NOT NULL,
  `diagnosis_id` INT NOT NULL,
  PRIMARY KEY (`visit_id`, `diagnosis_id`),
  INDEX `fk_visits_has_diagnoses_diagnoses1_idx` (`diagnosis_id` ASC) VISIBLE,
  INDEX `fk_visits_has_diagnoses_visits1_idx` (`visit_id` ASC) VISIBLE,
  CONSTRAINT `fk_visits_has_diagnoses_visits1`
    FOREIGN KEY (`visit_id`)
    REFERENCES `mydb`.`visits` (`visit_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_visits_has_diagnoses_diagnoses1`
    FOREIGN KEY (`diagnosis_id`)
    REFERENCES `mydb`.`diagnoses` (`diagnosis_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
