'Imports classes_xml_generees.LibRechProfil
'Imports classes_xml_generees.LibRechProfil.Referentiel

Imports classes_xml_generees.LibRechCandidat
Imports classes_xml_generees.LibRechCandidat.Referentiel






Namespace LibRechProfil

    Public Class matching_candidat

        Private mVacancy As New VACANCY


        Private mLanguage As String

        Private mJobTitle As String

        Private mLocation As String

        Private mReferenceNumber As String

        Private mPostingDate As String

        Private mApplicationDeadline As String

        Private mStartDate As String

        Private mNumberOfOpenings As String

        Private mOrganization As Organization

        Private mCandidateRequirements As CandidateRequirements

        Private mConditionsBenefits As ConditionsBenefits

        Private mSections As Sections

        Private mVacancyText As String

        Private mUserArea As UserArea

        Public Sub New()

        End Sub

        Public Function GetXML(ByVal lMapping As entite.MappingVacancy.vacancyMatching) As String

            ' languageField As String
            Me.Ajouter_Language(lMapping.language)

            'Private jobTitleField As String
            Me.Ajouter_JobTitle(lMapping.job_title)

            'Private mLocation As String
            Me.Ajouter_Location(lMapping.location)

            'Private mReferenceNumber As String
            Me.Ajouter_ReferenceNumber(lMapping.reference_number)

            'Private mPostingDate As String
            Me.Ajouter_PostingDate(lMapping.posting_date)

            'Private mApplicationDeadline As String
            Me.Ajouter_ApplicationDeadline(lMapping.application_deadline)

            'Private mStartDate As String
            Me.Ajouter_StartDate(lMapping.start_date)

            'Private mNumberOfOpenings As String
            Me.Ajouter_NumberOfOpenings(lMapping.number_of_opening)

            'Private mOrganization As Organization
            Me.mOrganization = Me.GetOrganization(lMapping.organization.name, lMapping.organization.addresse,
                                                   lMapping.organization.phone, lMapping.organization.email,
                                                   lMapping.organization.fax, lMapping.organization.website,
                                                   lMapping.organization.contact_person, lMapping.organization.industry)


            'Private mCandidateRequirements As CandidateRequirements

            'Private mConditionsBenefits As ConditionsBenefits

            'Private mSections As Sections

            'Private mVacancyText As String
            Me.mVacancyText = lMapping.vacancy_text

            'Private mUserArea As UserArea

            Me.mUserArea = New classes_xml_generees.LibRechCandidat.UserArea
            Me.mUserArea.dossier_complet = Me.GetUserArea_DossierComplet(lMapping.user_area.dossier_complet.priorite, lMapping.user_area.dossier_complet.flag)


            'Dim dossier As classes_xml_generees.LibRechCandidat.CritereFlag = Me.GetUserArea_DossierComplet(lMapping.user_area.dossier_complet.priorite, lMapping.user_area.dossier_complet.flag
            'Me.mUserArea.dossier_complet = dossier







            Me.Ajouter_UserArea_Qualification(lMapping.user_area.qualification.code, lMapping.user_area.qualification.libelle, lMapping.user_area.qualification.priorite)
            Me.Ajouter_UserArea_ContractType(lMapping.user_area.contract_type.code, lMapping.user_area.contract_type.libelle, lMapping.user_area.contract_type.priorite)
            Me.Ajouter_UserArea_NiveauEtude(lMapping.user_area.niveau_etude.code, lMapping.user_area.niveau_etude.libelle, lMapping.user_area.niveau_etude.priorite)
            Me.Ajouter_UserArea_Metier(lMapping.user_area.metier.code, lMapping.user_area.metier.libelle, lMapping.user_area.metier.priorite)

            Dim lMobiliteLength = lMapping.user_area.mobilite.Length
            Me.Ajouter_UserArea_Mobilite(lMapping.user_area.mobilite)

            Me.Ajouter_UserArea_DateDebut(lMapping.user_area.date_debut.priorite, lMapping.user_area.date_debut.date_critere)

            Me.Ajouter_UserArea_Permis(lMapping.user_area.permis.priorite, lMapping.user_area.permis.libelle, lMapping.user_area.permis.code)

            Me.Ajouter_UserArea_Competence(lMapping.user_area.competence)

            Me.Ajouter_UserArea_AnneeExperience(lMapping.user_area.annees_experience)

            Me.Ajouter_UserArea_Client(lMapping.user_area.client)

            Me.Ajouter_UserArea_Service(lMapping.user_area.service)

            Me.Ajouter_UserArea_Secteur(lMapping.user_area.secteur)

            Me.Ajouter_UserArea_Regroupement(lMapping.user_area.regroupement)

            Me.Ajouter_UserArea_Habilitation(lMapping.user_area.habilitation)

            Me.Ajouter_UserArea_Language(lMapping.user_area.langue)

            Me.Ajouter_UserArea_StatutCDITT(lMapping.user_area.statut_cdi_tt)

            Me.Ajouter_UserArea_TT400H(lMapping.user_area.tt_400h)

            Me.Ajouter_UserArea_FSPI(lMapping.user_area.fspi)

            Me.Ajouter_UserArea_Compte(lMapping.user_area.compte)

            Me.Ajouter_UserArea_AdresseDelegation(lMapping.user_area.addresse_delegation)

            Me.Ajouter_UserArea_Commune(lMapping.user_area.cp_commune)

            Me.ConsoliderDate()

            Return MthConvertXml.ConvertirObjetEnXMLDocument(mVacancy).OuterXml
        End Function


        Private Sub Ajouter_Language(ByVal language As String)
            Me.mLanguage = language
        End Sub

        Private Sub Ajouter_JobTitle(ByVal jobTitle As String)
            Me.mJobTitle = jobTitle
        End Sub

        Private Sub Ajouter_Location(ByVal location As String)
            Me.mLocation = location
        End Sub


        Private Sub Ajouter_ReferenceNumber(ByVal referenceNumber As String)
            Me.mReferenceNumber = referenceNumber
        End Sub

        Private Sub Ajouter_PostingDate(ByVal postingDate As String)
            Me.mPostingDate = postingDate
        End Sub


        Private Sub Ajouter_ApplicationDeadline(ByVal applicationDeadLine As String)
            Me.mApplicationDeadline = applicationDeadLine
        End Sub

        Private Sub Ajouter_StartDate(ByVal startDate As String)
            Me.mStartDate = startDate
        End Sub

        Private Sub Ajouter_NumberOfOpenings(ByVal numberOfOpening As String)
            If numberOfOpening = Nothing Then

                Me.mNumberOfOpenings = ""
            Else
                Me.mNumberOfOpenings = numberOfOpening
            End If

        End Sub


        Private Function GetOrganization(ByVal name As String, ByVal adress As String, ByVal phone As String,
                                          ByVal email As String, ByVal fax As String, ByVal website As String,
                                          ByVal contact As String, ByVal industry As String) As classes_xml_generees.LibRechCandidat.Organization
            Dim pRef As New classes_xml_generees.LibRechCandidat.Organization
            pRef.Name = name
            pRef.Address = adress
            pRef.Phone = phone
            pRef.Email = email
            pRef.Fax = fax
            pRef.Website = website
            pRef.ContactPerson = contact
            pRef.Industry = industry
            Return pRef
        End Function

        Private Sub Ajouter_Organization_Name(ByVal name As String)
            Me.mOrganization.Name = name
        End Sub

        Private Sub Ajouter_Organization_adresse(ByVal adresse As String)
            If adresse = Nothing Then
                Me.mOrganization.Address = ""
            Else
                Me.mOrganization.Address = adresse
            End If

        End Sub

        Private Sub Ajouter_Organization_Phone(ByVal phone As String)
            Me.mOrganization.Phone = phone
        End Sub

        Private Sub Ajouter_Organization_Email(ByVal email As String)
            Me.mOrganization.Email = email
        End Sub

        Private Sub Ajouter_Organization_Fax(ByVal fax As String)
            Me.mOrganization.Fax = fax
        End Sub

        Private Sub Ajouter_Organization_Website(ByVal website As String)
            Me.mOrganization.Website = website
        End Sub

        Private Sub Ajouter_Organization_ContractPerson(ByVal contractPerson As String)
            Me.mOrganization.ContactPerson = contractPerson
        End Sub

        Private Sub Ajouter_Organization_Industry(ByVal industry As String)
            Me.mOrganization.Industry = industry
        End Sub

        Private Function GetUserArea_DossierComplet(ByVal flag As Boolean, ByVal priorite As Integer) As classes_xml_generees.LibRechCandidat.CritereFlag
            Dim dossier As New classes_xml_generees.LibRechCandidat.CritereFlag
            dossier.flag = flag
            dossier.priorite = priorite
            dossier.flagSpecified = True
            dossier.prioriteSpecified = True
            Return dossier
        End Function

        Private Sub Ajouter_UserArea_Qualification(ByVal code As String, ByVal libelle As String, priorite As Integer)
            Dim lRf As New classes_xml_generees.LibRechCandidat.CritereReferentiel
            lRf.code = code
            lRf.libelle = libelle
            lRf.priorite = priorite

            Me.mUserArea.qualification = lRf
        End Sub

        Private Sub Ajouter_UserArea_ContractType(ByVal code As String, ByVal libelle As String, priorite As Integer)
            Me.mUserArea.contracttype.priorite = priorite
            Me.mUserArea.contracttype.code = code
            Me.mUserArea.contracttype.libelle = libelle
        End Sub

        Private Sub Ajouter_UserArea_NiveauEtude(ByVal code As String, ByVal libelle As String, priorite As Integer)
            Me.mUserArea.niveau_etude.priorite = priorite
            Me.mUserArea.niveau_etude.code = code
            Me.mUserArea.niveau_etude.libelle = libelle
        End Sub

        Private Sub Ajouter_UserArea_Metier(ByVal code As String, ByVal libelle As String, priorite As Integer)
            Me.mUserArea.metier.code = code
            Me.mUserArea.metier.libelle = libelle
            Me.mUserArea.metier.priorite = priorite
        End Sub

        Private Sub Ajouter_UserArea_Mobilite(ByVal mobilites() As entite.MappingVacancy.vacancyMatching.userArea.CritereReferentiel)
            Dim lMobiliteLength = mobilites.Length
            Dim lMobilite() As classes_xml_generees.LibRechCandidat.CritereReferentiel = New classes_xml_generees.LibRechCandidat.CritereReferentiel(lMobiliteLength) {}
            For index As Integer = 0 To lMobiliteLength - 1
                lMobilite(index) = Me.GetCritereReferentiel(mobilites(index).code, mobilites(index).libelle, mobilites(index).priorite)
            Next

            Me.mUserArea.mobilite = lMobilite
        End Sub

        Private Sub Ajouter_UserArea_DateDebut(ByVal priorite As Integer, ByVal critereDate As Date)
            Me.mUserArea.date_debut = Me.GetCritereDate(critereDate, priorite)
        End Sub

        Private Sub Ajouter_UserArea_Permis(ByVal priorite As Integer, ByVal libelle As String, ByVal code As String)
            Me.mUserArea.permis = Me.GetCritereReferentiel(code, libelle, priorite)
        End Sub

        Private Sub Ajouter_UserArea_Competence(ByVal competences() As entite.MappingVacancy.vacancyMatching.userArea.CritereReferentiel)
            Dim lCompetenceLength = competences.Length
            Dim lCompetence() As classes_xml_generees.LibRechCandidat.CritereReferentiel = New classes_xml_generees.LibRechCandidat.CritereReferentiel(lCompetenceLength) {}

            For index As Integer = 0 To lCompetenceLength - 1
                lCompetence(index) = Me.GetCritereReferentiel(competences(index).code, competences(index).libelle, competences(index).priorite)
            Next

            Me.mUserArea.competence = lCompetence
        End Sub


        Private Sub Ajouter_UserArea_AnneeExperience(ByVal anneeExperience As entite.MappingVacancy.vacancyMatching.userArea.CritereFloat)
            Me.mUserArea.annees_experience = Me.GetCritereFloat(anneeExperience.nombre, anneeExperience.priorite)
        End Sub


        Private Sub Ajouter_UserArea_Client(ByVal client As entite.MappingVacancy.vacancyMatching.userArea.CritereReferentiel)
            Me.mUserArea.client = Me.GetCritereReferentiel(client.code, client.libelle, client.priorite)
        End Sub

        Private Sub Ajouter_UserArea_Secteur(ByVal secteur As entite.MappingVacancy.vacancyMatching.userArea.CritereReferentiel)
            Me.mUserArea.secteur = Me.GetCritereReferentiel(secteur.code, secteur.libelle, secteur.priorite)
        End Sub

        Private Sub Ajouter_UserArea_Service(ByVal service As entite.MappingVacancy.vacancyMatching.userArea.CritereReferentiel)
            Me.mUserArea.service = Me.GetCritereReferentiel(service.code, service.libelle, service.priorite)
        End Sub

        Private Sub Ajouter_UserArea_Regroupement(ByVal regroupement As entite.MappingVacancy.vacancyMatching.userArea.CritereReferentiel)
            Me.mUserArea.regroupement = Me.GetCritereReferentiel(regroupement.code, regroupement.libelle, regroupement.priorite)
        End Sub


        Private Sub Ajouter_UserArea_Diplome(ByVal diplome As entite.MappingVacancy.vacancyMatching.userArea.DiplomeReferentiel)
            Me.mUserArea.diplome = Me.GetCritereDiplome(diplome.code, diplome.libelle, diplome.priorite, diplome.obtenu)
        End Sub


        Private Sub Ajouter_UserArea_Habilitation(ByVal habilitation() As entite.MappingVacancy.vacancyMatching.userArea.HabilitationReferentiel)
            Dim lHabilitationLength = habilitation.Length
            Dim lHabilitation() As classes_xml_generees.LibRechCandidat.CritereHabilitation = New classes_xml_generees.LibRechCandidat.CritereHabilitation(lHabilitationLength) {}

            For index As Integer = 0 To lHabilitationLength
                lHabilitation(index) = Me.GetCritereHabilitation(habilitation(index).code, habilitation(index).libelle, habilitation(index).priorite, habilitation(index).date_de_validite)
            Next

            Me.mUserArea.habilitation = lHabilitation
        End Sub


        Private Sub Ajouter_UserArea_Language(ByVal langues() As entite.MappingVacancy.vacancyMatching.userArea.CritereReferentiel)
            Dim lLangueLength = langues.Length
            Dim lLangue() As classes_xml_generees.LibRechCandidat.CritereReferentiel = New classes_xml_generees.LibRechCandidat.CritereReferentiel(lLangueLength) {}

            For index As Integer = 0 To lLangueLength
                lLangue(index) = Me.GetCritereReferentiel(langues(index).code, langues(index).libelle, langues(index).priorite)
            Next

            Me.mUserArea.langue = lLangue
        End Sub

        Private Sub Ajouter_UserArea_VisiteMedicale(ByVal visite As entite.MappingVacancy.vacancyMatching.userArea.CritereDate)
            Me.mUserArea.visite_medicale_a_jour = Me.GetCritereDate(visite.date_critere, visite.priorite)
        End Sub

        Private Sub Ajouter_UserArea_StatutCDITT(ByVal statut As entite.MappingVacancy.vacancyMatching.userArea.CritereFlag)
            Me.mUserArea.statut_cdi_tt = Me.GetCritereFlag(statut.flag, statut.priorite)
        End Sub

        Private Sub Ajouter_UserArea_TT400H(ByVal pRef As entite.MappingVacancy.vacancyMatching.userArea.CritereFlag)
            Me.mUserArea.tt_400h = Me.GetCritereFlag(pRef.flag, pRef.priorite)
        End Sub

        Private Sub Ajouter_UserArea_FSPI(ByVal pRef As entite.MappingVacancy.vacancyMatching.userArea.CritereFlag)
            Me.mUserArea.fspi = Me.GetCritereFlag(pRef.flag, pRef.priorite)
        End Sub

        Private Sub Ajouter_UserArea_Compte(ByVal pRef As entite.MappingVacancy.vacancyMatching.userArea.compteMatching)
            Me.mUserArea.compte = Me.GetCritereCompte(pRef.matricule_cli, pRef.nom, pRef.sigle)
        End Sub

        Private Sub Ajouter_UserArea_AdresseDelegation(ByVal pRef As entite.MappingVacancy.vacancyMatching.userArea.AdresseReferentiel)
            Me.mUserArea.adresse_delegation = Me.GetAdresseDelegation(pRef.ligne1, pRef.ligne2, pRef.ligne3, pRef.ligne4, pRef.latitude, pRef.longitude, pRef.priorite)
        End Sub

        Private Sub Ajouter_UserArea_Commune(ByVal pRef As entite.MappingVacancy.vacancyMatching.userArea.Referentiel)
            Me.mUserArea.cp_commune = Me.GetReferentiel(pRef.code, pRef.libelle)
        End Sub



        Private Function GetAdresseDelegation(ByVal ligne1 As String, ByVal ligne2 As String, ByVal ligne3 As String, ByVal ligne4 As String, ByVal latitude As String, ByVal longitude As String, ByVal priotite As Integer) As classes_xml_generees.LibRechCandidat.Adresse
            Dim pRef As New classes_xml_generees.LibRechCandidat.Adresse
            pRef.ligne1 = ligne1
            pRef.ligne2 = ligne2
            pRef.ligne3 = ligne3
            pRef.ligne4 = ligne4
            pRef.latitude = latitude
            pRef.longitude = longitude
            pRef.priorite = priotite
            Return pRef
        End Function
        Private Function GetCritereCompte(ByVal matricule As String, ByVal nom As String, ByVal sigle As String) As classes_xml_generees.LibRechCandidat.Compte
            Dim lCompte As New classes_xml_generees.LibRechCandidat.Compte()
            lCompte.matriculeCli = matricule
            lCompte.nom = nom
            lCompte.sigle = sigle
            Return lCompte
        End Function

        Private Function GetCritereHabilitation(ByVal pCode As String, ByVal pLibelle As String, ByVal pPriorite As Integer, ByVal pDate As Date) As classes_xml_generees.LibRechCandidat.CritereHabilitation
            Dim lRef As New classes_xml_generees.LibRechCandidat.CritereHabilitation()
            lRef.priorite = pPriorite
            lRef.code = pCode
            lRef.libelle = pLibelle
            lRef.date_de_validite = pDate
            Return lRef
        End Function


        Private Function GetCritereDiplome(ByVal pCode As String, ByVal pLibelle As String, ByVal pPriorite As Integer, ByVal pObtenu As Boolean) As classes_xml_generees.LibRechCandidat.CritereDiplome
            Dim lRef As New classes_xml_generees.LibRechCandidat.CritereDiplome()
            lRef.priorite = pPriorite
            lRef.code = pCode
            lRef.libelle = pLibelle
            lRef.obtenu = pObtenu
            Return lRef
        End Function



        Private Function GetCritereFloat(ByVal pNombre As Single, ByVal pPriorite As Integer) As classes_xml_generees.LibRechCandidat.CritereFloat
            Dim lCritereFloat As New classes_xml_generees.LibRechCandidat.CritereFloat()
            lCritereFloat.nombre = pNombre
            lCritereFloat.nombreSpecified = True
            lCritereFloat.priorite = pPriorite
            lCritereFloat.prioriteSpecified = True
            Return lCritereFloat
        End Function

        Private Function GetCritereDate(ByVal pDate As Date, ByVal pPriorite As Integer) As classes_xml_generees.LibRechCandidat.CritereDate
            Dim lCritereDate As New classes_xml_generees.LibRechCandidat.CritereDate()
            lCritereDate.date = pDate
            lCritereDate.dateSpecified = True
            lCritereDate.priorite = pPriorite
            lCritereDate.prioriteSpecified = True
            Return lCritereDate
        End Function


        Private Function GetCritereFlag(ByVal pflag As Boolean, ByVal pPriorite As Integer) As classes_xml_generees.LibRechCandidat.CritereFlag
            Dim lCritereFlag As New classes_xml_generees.LibRechCandidat.CritereFlag()
            lCritereFlag.flag = pflag
            lCritereFlag.flagSpecified = True
            lCritereFlag.priorite = pPriorite
            lCritereFlag.prioriteSpecified = True
            Return lCritereFlag
        End Function

        Private Function GetReferentiel(ByVal code As String, ByVal libelle As String) As classes_xml_generees.LibRechCandidat.Referentiel
            Dim lRef As New classes_xml_generees.LibRechCandidat.Referentiel
            lRef.code = code
            lRef.libelle = libelle
            Return lRef
        End Function

        Private Function GetCritereReferentiel(ByVal pCode As String, ByVal pLibelle As String, ByVal pPriorite As Integer) As classes_xml_generees.LibRechCandidat.CritereReferentiel
            Dim lRef As New classes_xml_generees.LibRechCandidat.CritereReferentiel()
            lRef.priorite = pPriorite
            lRef.code = pCode
            lRef.libelle = pLibelle
            Return lRef
        End Function

        Private Function GetCritereReferentiel(ByVal critereReferentiel As classes_xml_generees.LibRechCandidat.CritereReferentiel)
            Dim ref = New classes_xml_generees.LibRechCandidat.CritereReferentiel
            ref.code = critereReferentiel.code
            ref.libelle = critereReferentiel.libelle
            ref.priorite = critereReferentiel.priorite
            Return ref
        End Function

        Private Sub ConsoliderDate()
            mVacancy.Language = mLanguage
        End Sub

    End Class


    '---------------------------------------------------------------------------------------------

End Namespace
